/* 1 - Verilmiş ədədin ikinin qüvvəti olub olmadığını yoxlayan alqoritm yazın */

let givenNumber = 13;
let answer = false;
let numb = 2;
if (givenNumber >= 0) {

    for (let i = 0; i <= (givenNumber / 2); i++) {
        /**tek 2,4 olanda yarsi qeder quvvet olur,diger hallarda
         *  yarisindan az olur deye givenNumber/2 den <= yazdim 
         *  bir de givenNumbere qeder axtarmasin ,vaxt ve yaddas itkisi olmasin
        */

        if ((numb ** i) == givenNumber) {
            answer = true;
            console.log("this number is " + i + " times power of 2");
            break;
        }



    }
    if (answer == false) {
        console.log("this number is not any power of 2");
    }


}


else {
    console.log("Your number must be positive!!!!");
}
