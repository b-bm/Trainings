﻿if($_POST){   
    $selected_type=trim($_POST['type']);   
}

foreach ($result as $value) {   
            $columns= explode('**', $value);

            /* да се показват само разходите за избрания филтър и тяхната сума */
            /* Добавено е само isset($selected_type), за да проверява дали е инициализиран $selected_type, т.е. дали е изпратена информация през формата за филтриране */
           
            if ( isset($selected_type)  && ( (int)$columns[3] == $selected_type || $selected_type == 'all' ) ) {   
                echo '<tr>
                <td>'.$columns[0].'</td>
                <td>'.$columns[1].'</td>
                <td>'.$columns[2].'</td>
                <td>'.$type[trim($columns[3])].'</td>
                </tr>';
                $sum+= (float)$columns[2];
            }
            else {
                echo '<tr>
                <td>'.$columns[0].'</td>
                <td>'.$columns[1].'</td>
                <td>'.$columns[2].'</td>
                <td>'.$type[trim($columns[3])].'</td>
                </tr>';   
                $sum+= (float)$columns[2];
            }   
}\

/*(условие) ? (оператор 1) : (оператор 2)
Това е съкратен запис на конструкцията if(){}else{}, когато условието е изпълнено се изпълнява оператор 1, когато не е изпълнено се изпълнява 2.
Предимството е, че е по- кратко като запис, но кодът става по- трудно четим и разбираем.
Признавам си, че от доста време пиша код, но доскоро ми беше доста трудно да схвана, какво точно се случва при използване на тази конструкция. Не се притеснявай ако не го схващаш веднага, дори и да използваш пълния if ... else... не е грешка.
commented 1 day ago by Krasimir Nikolov Junior Ninja
По скоро проблема е че не разбирам цикъла foreach, прегледах всички домашни тук и не мога да си обясня как точно цикъла бива накаран да покаже стойностите които му се филтрират. Т.е. при едно и също обхождане къде точно става промяната ?
commented 22 hours ago by Xooroox
Цикълът няма как да филтрира, той показва всички елементи от списъка. За да не покажеш някой ред трябва да имаш if...
commented 21 hours ago by Krasimir Nikolov Junior Ninja
Добре но например в това домашно https://github.com/mariya-ivanova/MyRepository/tree/master/Razhodi на кой точно ред if условието задава нещата така че да се покаже само това което филтъра задава, къде се присвоява или ... ?
commented 21 hours ago by Xooroox
/* да се показват само разходите за избрания филтър и тяхната сума */
                if((int)$columns[3] == $selected_type || $selected_type == 'all'){
commented 21 hours ago by Krasimir Nikolov Junior Ninja
Това и аз го виждам, не не разбирам как това оказва влияние по такъв начин че избрания филтър да спира показването на другите. И също така това което се изпълнява и в else след 64 ред е същото като в if. Не знам вече пети ден се занимава с това и не мога да го схвана.  
Все пак много благодаря за вниманието и обясненията.
commented 20 hours ago by Xooroox
$selected_type=trim($_POST['type']);
Тук се сетва селектираната стойност от филтъра, след това се показват само редовете, които имат такъв тип.
На 64 ред се показва последния ред със сумата.
commented 20 hours ago by Krasimir Nikolov Junior Ninja
Else-a на 64 ред НЕ Е за този if :

    if((int)$columns[3] == $selected_type || $selected_type == 'all'){   

а е за горния :

    if($_POST){

най-груби ако си цъкнал филтрирай в конкретния случай, $_POST ще има някакви неща в него, иначе няма да има и ще върне false, което ще мине вече на else-a

Това е първата част ... цъканл си филтрирай if($_POST) ти връща True и влизам в нея част, долният 'else' въобще не се изпълнява.

Следващата част, която се намира между if ($_POST) { .... ТУК ... } имаме още един if :

/* да се показват само разходите за избрания филтър и тяхната сума */
                if((int)$columns[3] == $selected_type || $selected_type == 'all'){

Който вече проверява дали columns[3]  ( което ти е вида разход за съответния ред ) е равен на този който сме изпратили през формата за филтриране $selected_type ИЛИ дали сме избрали всички ( $selected_type == 'all' ... Ако едно от двете условия е вярно ти връща реда с информацията, ако не е вярно нито едно от двете, не прави нищо ( няма else ). По този начин пропуска разходите от различен вид от филтрирания.

Малко странно го обясних, много даже ... Ето вариант на същия код ( само foreach-a ), който прави абсолютно същото, но е написан без if във if-а, за да изглежда по-лесно за разбиране :

ТЦ не : ) Секунда, че пиша глупости ...

if($_POST){   
    $selected_type=trim($_POST['type']);   
}

foreach ($result as $value) {   
            $columns= explode('!', $value);

            /* да се показват само разходите за избрания филтър и тяхната сума */
            /* Добавено е само isset($selected_type), за да проверява дали е инициализиран $selected_type, т.е. дали е изпратена информация през формата за филтриране */
           
            if ( isset($selected_type)  && ( (int)$columns[3] == $selected_type || $selected_type == 'all' ) ) {   
                echo '<tr>
                <td>'.$columns[0].'</td>
                <td>'.$columns[1].'</td>
                <td>'.$columns[2].'</td>
                <td>'.$type[trim($columns[3])].'</td>
                </tr>';
                $sum+= (float)$columns[2];
            }
            else {
                echo '<tr>
                <td>'.$columns[0].'</td>
                <td>'.$columns[1].'</td>
                <td>'.$columns[2].'</td>
                <td>'.$type[trim($columns[3])].'</td>
                </tr>';   
                $sum+= (float)$columns[2];
            }   
}
commented 20 hours ago by Stan Kolev
*/