/* 4 - Ay(month) adı daxil edilir. Çıxışa hansı fəsil olduğunu yazdırsın (switch case ilə yazın) */

let monthName = "October";

switch (monthName) {
    case 'December':
    case 'January':
    case 'February':
        console.log(" Season:  Winter");
        break;
    case 'March':
    case 'April':
    case 'May':
        console.log("Season : Spring ");
        break;
    case 'June':
    case 'July':
    case 'August':
        console.log("Season : Summer ");
        break;
    case 'September':
    case 'October':
    case 'November':
        console.log("Season : Autumn ");
        break;
    default :
    console.log(" please ,enter Month name correctly !");

}