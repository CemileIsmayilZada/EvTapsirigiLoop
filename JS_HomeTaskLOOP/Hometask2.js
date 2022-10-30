/* 2 - Daxil edilən müsbət tam ədədin palindrom olub-olmamasını yoxlayın */

let givenNumber = 128;
let palindrom = 0;
let myNumber = givenNumber;

if (myNumber > 0) {
    while (givenNumber >= 1) {

        palindrom = palindrom * 10 + ((givenNumber % 10)); //8  2  1
        //console.log(palindrom);
        givenNumber = ~~(givenNumber / 10); //12 1 

    }

    console.log("our palindrom of " + myNumber + " is : " + palindrom);

    if (palindrom == myNumber) {
        console.log("Due to this, this number's palindrom is  equal to itself");
    } else {
        console.log("Due to this, this number's palindrom is not equal to itself");

    }
}
else {
    console.log(" Musbet eded daxil edin!");
}

