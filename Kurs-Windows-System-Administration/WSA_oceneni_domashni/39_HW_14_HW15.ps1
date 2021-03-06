<#
3) Generate File System Report 
Write a script to collect the following details: 
* The File System type 
* The cluster size of the file system 
* Total files on the disk 
* The bigest file on the volume and its size 
* The most used file extension and the total capacity of all files with that extension 
* All shares that are hosted on the drive 
#>

#------------
# The File System type
#------------

Write-Host "The File System Type is" ([System.IO.DriveInfo]::GetDrives()| Select-Object | Where-Object {$_.IsReady -eq $true}).DriveFormat

#[System.IO.DriveInfo]::GetDrives() if you want to see all
#select all real file system NTFS 

#------------
# The cluster size of the file system
#------------

Write-Host "The cluster size of main partition is:"

Get-WmiObject -Class win32_Diskpartition | Select-Object -Property name, size, blocksize | Where-Object {$_.size -gt 10000000000}

#The cluster file size of the system

#------------
# Total files on the disk
#------------

$allFiles = Get-ChildItem C:\ -force -Recurse -ErrorAction SilentlyContinue

Write-Host "The total number of files on the disk is:" $allFiles.Count

# Total files on the disk

#------------
# The bigest file on the volume and its size
#------------

[long]$fileSystemSize=0
[string]$fileName

foreach ($file in $allFiles)
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

# The bigest file on the volume and its size 

#-------------
# The most used file extension and the total capacity of all files with that extension
#-------------

$allFiles | group Extension -NoElement | sort count -Descending | Out-File -FilePath ".\SortedFiles.txt" -Encoding utf8 -append

$content = Get-Content .\SortedFiles.txt 
[array]$mostUsedFileExtension = $content[3].Split(".")
[string]$fileExtension = "." + $mostUsedFileExtension[1]
$fileExtension = $fileExtension.Replace(" ","")
Write-Host "The most used file extension in the system is" $fileExtension

$listMostUsedFileExtension = $allFiles | Where {$_.extension -eq [string]$fileExtension}

[long]$capacityMostUsedFiles = 0

foreach ($file in $listMostUsedFileExtension)
{
	$capacityMostUsedFiles+=$file.Length
}


$capacityMostUsedFiles=$capacityMostUsedFiles/(1024*1024)
# convert size in MB

Write-Host "Capacity of all" $fileExtension "is" $capacityMostUsedFiles "MB"

# The most used file extension and the total capacity of all files with that extension

#------------
# All shares that are hosted on the drive
#------------

$allShares = Get-WmiObject -class Win32_Share -ComputerName (Get-Content env:computername)

Write-Host "All shared item in the system are" $allShares

# All shares that are hosted on the drive 
