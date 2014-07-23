# WSA - HW – 14 :
# 8. Shares
# Write a script in PowerShell that provide the following details:
# - List all shares on a server and their location (e.g. D:\Shares\Profile)
# - Provide information for disk space usage and free space on the drive
# Note: Read about WMI technology.

# - get shares:
# $Share = gwmi Win32_Share | sort type, name | ft -autosize name, description, path

# - get free space:
# $Space = gwmi win32_volume -Filter 'drivetype = 3' | select driveletter, label, @{LABEL='GBfreespace';EXPRESSION={"{0:N2}" -f ($_.freespace/1GB)} }

# - Colect info:
# $Share,$Space | Out-File C:\Downloads\share_and_driveInfo_list.txt

# or:

$Share = gwmi Win32_Share | sort type, name | ft -autosize name, description, path
$Space = gwmi win32_volume -Filter 'drivetype = 3' | select driveletter, label, @{LABEL='freespace in GB';EXPRESSION={"{0:N2}" -f ($_.freespace/1GB)} }
$Share,$Space | Out-File C:\Downloads\share_and_driveInfo_list.txt