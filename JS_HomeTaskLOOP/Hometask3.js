/* 3 - Daxil olunan müsbət tam ədədin sadə və ya mürəkkəb olduğunu tapın */

let number = 3;
let check = false;
if (number < 0) {
    console.log("Enter positive number! ");
}

else if (number == 0 && number == 1) {
    console.log("It is not Prime or Composite number");

}


else {
    for (let i = 2; i < number; i++) {
        if (number / i == 0) {
            check = true;
        }
    }
    if (check == true) {
        console.log("Number is Composite number ");
    }
    else {
        console.log("Number is Prime number ");
    }


}