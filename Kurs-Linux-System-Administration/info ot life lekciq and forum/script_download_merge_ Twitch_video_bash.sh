# //by hackman -> Ето го и обещаният скрипт за download & merge на Twitch клипчетата:

#!/bin/bash

if [ $# -ne 1 ]; then
        echo "Usage: $0 twitch_video_id"
        exit 0
fi

id=$1
video_urls=( $(curl http://api.justin.tv/api/broadcast/by_archive/${id}.xml?onsite=true | grep video_file_url | sed 's/.*url>\(http:.*\)<\/vid.*/\1/') )

if [ -d ~/lsa ]; then
        mkdir ~/lsa
fi

cd ~/lsa

for i in ${video_urls[*]}; do
        wget -c $i
done

rm -f int*.ts
concat_list='concat:'
last_num=${#video_urls[*]}
let last_num--
for i in $( seq 0 $last_num ); do
        ffmpeg -i ${video_urls[$i]/*\//} -c copy -bsf:v h264_mp4toannexb -f mpegts int${i}.ts
        concat_list="$concat_list:${video_urls[$i]/*\//}"
        if [ "$i" -ne "$last_num" ]; then
                concat_list="$concat_list|"
        fi
done

ffmpeg -f mpegts -i "$concat_list" -c copy for_youtube.flv
