<#
3) Generate File System Report 
Write a script to collect the following details: 
 The File System type 
 The cluster size of the file system 
 Total files on the disk 
 The big file on the volume and its size 
 The most used file extension and the total capacity of all files with that extension 
 All shares that are hosted on the drive 
#>

#------------
#Task1
#------------

Write-Host "The File System Type is" ([System.IO.DriveInfo]::GetDrives()| Select-Object | Where-Object {$_.IsReady -eq $true}).DriveFormat

#[System.IO.DriveInfo]::GetDrives() if you want to see all
#select all real file system NTFS 

#------------
#Task2
#------------

Write-Host "The cluster size of main partition is:"

Get-WmiObject -Class win32_Diskpartition | Select-Object -Property name, size, blocksize | Where-Object {$_.size -gt 10000000000}

#The cluster file size of the system

#------------
#Task3
#------------

$allItem = Get-ChildItem C:\ -force -Recurse -ErrorAction SilentlyContinue

Write-Host "The total files in the disk are" $allItem.Count

#The total number of files in the system

#------------
#Task4
#------------

[long]$fileSystemSize=0
[string]$fileName

foreach ($file in $allItem)
{
	if($fileSystemSize -lt $file.Length)
		{
			$fileSystemSize = $file.Length
			$fileName=$file.Name
		}
	else
	{}
}

$fileSystemSize=$fileSystemSize/(1024*1024)
# convert size in MB

Write-Host "The biggest file in the system is" $fileSystemSize "MB"
Write-Host "and his name is" $fileName
# The big file on the volume and its size 

#-------------
#Task 5
#-------------

$allItem | group Extension -NoElement | sort count -Descending | Out-File -FilePath "C:\SortedFiles.txt" -Encoding utf8 -append

$content = Get-Content C:\SortedFiles.txt 
[array]$mostUsedFileExtension = $content[3].Split(".")
[string]$fileExtension = "." + $mostUsedFileExtension[1]
$fileExtension = $fileExtension.Replace(" ","")
Write-Host "The most used file extension in the system is" $fileExtension

#TO DO: fix to work with variable (possible limitation of powershell 2.0?!)
#Input the result in my case .dll
#I try to add $fileExtension in my case the return result is 0
# After some investigation and help of B.V. the cast to [string]finally work
$listMostUsedFileExtension = $allItem | Where {$_.extension -eq [string]$fileExtension}

[long]$capacityMostUsedFiles = 0

foreach ($file in $listMostUsedFileExtension)
{
	$capacityMostUsedFiles+=$file.Length
}

Write-Host "Capacity of all" $fileExtension "is" $capacityMostUsedFiles

# The most used file extension and the total capacity of all files with that extension

#------------
#Task 6
#------------

$allShares = Get-WmiObject -class Win32_Share -ComputerName (Get-Content env:computername)

Write-Host "All shared item in the system are" $allShares

#All shares that are hosted on the drive 
