/*
Name: Assignment 1
Course Code: SODV1201
Class: Software Development Diploma program
Author: Colin From
*/

//Setup and Function of Footer Date
//Set days of the week and months of the year as well as setting the current date for later use
var daysOfWeek = ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"];
var monthsOfYear = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];
var date = new Date();

//Set current date in footer
document.getElementById('currentDate').innerHTML = daysOfWeek[date.getDay()] + ", " + monthsOfYear[date.getMonth()] + " " + date.getDate() + ", " + date.getFullYear();


//Functions for index.html(Home Page)
//Used to show name on index page after 10 seconds
function showName() {
    setTimeout(function () {
        document.getElementById('name').style.display = "block";
    }, 10000);
};


//Functions for markToGradeConverter.html(Grade Converter Page)
//Function for giving grade based on user given mark value
function calculateGrade() {
    //Create variables for use later...
    var output = document.getElementById('grade');
    var input = parseInt(document.getElementById('studentMark').value);

    //Check if input is a number
    if (isNaN(input)) {
        output.innerHTML = "Please enter a number...";
    }
    //Check if input is positive or negative value
    else if (input < 0) {
        output.innerHTML = "Please enter a non-negative value...";
    }
    //Check if input is greater than 100
    else if (input > 100) {
        output.innerHTML = "Please enter a value no greater than 100...";
    }
    //Check input value and give grade letter accordingly
    else {
        var result = ""; //Create variable to hold letter
        switch (true) {
            case (input >= 90):
                result = "A";
                break;
            case input >= 80:
                result = "B";
                break;
            case input >= 70:
                result = "C";
                break;
            case input >= 50:
                result = "D";
                break;
            case input < 50:
                result = "F";
                break;
        }
        output.innerHTML = "Grade " + result; //Output grade letter
    }
    document.getElementById('studentMark').value = ""; //Reset field for user
}

//Setup and Functions for staff.html(Staff Page)
var clicksName = 0, clicksTitle = 0, clicksCity = 0, clicksID = 0, clicksHired = 0, clicksSalary = 0;
var staff = [
    ["Brielle Williamson", "Integration Specialist", "New York", "4804", "2012/12/02", "$372,000"],
    ["Herrod Chandler", "Sales Assistant", "San Francisco", "9608", "2012/08/06", "$137,500"],
    ["Rhona Davidson", "Integration Specialist", "Tokyo", "6200", "2010/10/14", "$327,900"],
    ["Colleen Hurst", "Javascript Developer", "San Francisco", "2360", "2009/09/15", "$205,500"],
    ["Sonya Frost", "Software Engineer", "Edinburgh", "1667", "2008/12/13", "$103,600"],
    ["Jena Gaines", "Office Manager", "London", "3814", "2008/12/19", "$90,560"],
    ["Quinn Flynn", "Support Lead", "Edinburgh", "9497", "2013/03/03", "$342,000"],
    ["Tiger Nixon", "System Architect", "Edinburgh", "5421", "2011/04/25", "$320,800"],
    ["Garrett Winters", "Accountant", "Tokyo", "8422", "2011/07/25", "$170,750"],
    ["Ashton Cox", "Junior Technical Author", "San Francisco", "1562", "2009/01/12", "$86,000"],
    ["Cedric Kelly", "Senior Javascript Developer", "Edinburgh", "6224", "2012/03/29", "$433,060"],
    ["Airi Satou", "Accountant", "Tokyo", "5407", "2008/11/28", "$162,700"],
    ["Charde Marshall", "Regional Director", "San Francisco", "6741", "2008/10/16", "$470,600"],
    ["Haley Kennedy", "Senior Marketing Designer", "London", "3597", "2012/12/18", "$313,500"],
    ["Tatyana Fitzpatrick", "Regional Director", "London", "1965", "2010/03/17", "$385,750"],
    ["Michael Silva", "Marketing Designer", "London", "1581", "2012/11/27", "$198,500"],
    ["Paul Byrd", "Chief Financial Officer (CFO)", "New York", "3059", "2010/06/09", "$725,000"],
    ["Gloria Little", "Systems Administrator", "New York", "1721", "2009/04/10", "$237,500"],
    ["Bradley Greer", "Software Engineer", "London", "2558", "2012/10/13", "$132,000"],
    ["Dai Rios", "Personnel Lead", "Edinburgh", "2290", "2012/09/26", "$217,500"],
    ["Jenette Caldwell", "Development Lead", "New York", "1937", "2011/09/03", "$345,000"],
    ["Yuri Berry", "Chief Marketing Officer (CMO)", "New York", "6154", "2009/06/25", "$675,000"],
    ["Caesar Vance", "Pre-Sales Support", "New York", "8330", "2011/12/12", "$106,450"],
    ["Doris Wilder", "Sales Assistant", "Sidney", "3023", "2010/09/20", "$85,600"],
    ["Angelica Ramos", "Chief Executive Officer (CEO)", "London", "5797", "2009/10/09", "$1,200,000"],
    ["Gavin Joyce", "Developer", "Edinburgh", "8822", "2010/12/22", "$92,575"],
    ["Jennifer Chang", "Regional Director", "Singapore", "9239", "2010/11/14", "$357,650"],
    ["Brenden Wagner", "Software Engineer", "San Francisco", "1314", "2011/06/07", "$206,850"],
    ["Fiona Green", "Chief Operating Officer (COO)", "San Francisco", "2947", "2010/03/11", "$850,000"],
    ["Shou Itou", "Regional Marketing", "Tokyo", "8899", "2011/08/14", "$163,000"],
    ["Michelle House", "Integration Specialist", "Sidney", "2769", "2011/06/02", "$95,400"],
    ["Suki Burks", "Developer", "London", "6832", "2009/10/22", "$114,500"],
    ["Prescott Bartlett", "Technical Author", "London", "3606", "2011/05/07", "$145,000"],
    ["Gavin Cortez", "Team Leader", "San Francisco", "2860", "2008/10/26", "$235,500"],
    ["Martena Mccray", "Post-Sales support", "Edinburgh", "8240", "2011/03/09", "$324,050"],
    ["Unity Butler", "Marketing Designer", "San Francisco", "5384", "2009/12/09", "$85,675"]
];

function initialDisplay() {
    var table = document.getElementById('staffTable');
    staff.forEach(index => {
        var row = table.insertRow(-1);
        index.forEach(element => {
            var cell = row.insertCell(-1);
            cell.innerHTML = element;
        });
    });
}

function sortName() {
    if (clicksName == 0) {
        staff.sort();
        clicksName = 1;
    }
    else if (clicksName == 1) {
        staff.sort().reverse();
        clicksName = 0;
    }
    displayStaff();
}

function sortTitle() {
    if (clicksCity == 0) {
        clicksName = 0;
        sortName();
        staff.sort((a, b) => a[1].localeCompare(b[1]));
        clicksCity = 1;
    }
    else if (clicksCity == 1) {
        clicksName = 0;
        sortName();
        staff.sort((a, b) => b[1].localeCompare(a[1]));
        clicksCity = 0;
    }
    displayStaff();
}

function sortCity() {
    if (clicksCity == 0) {
        clicksName = 0;
        sortName();
        staff.sort((a, b) => a[2].localeCompare(b[2]));
        clicksCity = 1;
    }
    else if (clicksCity == 1) {
        clicksName = 0;
        sortName();
        staff.sort((a, b) => b[2].localeCompare(a[2]));
        clicksCity = 0;
    }
    displayStaff();
}

function sortID() {
    if (clicksHired == 0) {
        staff.sort((a, b) => a[3] - b[3]);
        clicksHired = 1;
    }
    else if (clicksHired == 1) {
        staff.sort((a, b) => b[3] - a[3]);
        clicksHired = 0;
    }
    displayStaff();
}

function sortHired() {
    if (clicksHired == 0) {
        staff.sort((a, b) => a[4].replaceAll('/', '') - b[4].replaceAll('/', ''));
        clicksHired = 1;
    }
    else if (clicksHired == 1) {
        staff.sort((a, b) => b[4].replaceAll('/', '') - a[4].replaceAll('/', ''));
        clicksHired = 0;
    }
    displayStaff();
}

function sortSalary() {
    if (clicksSalary == 0) {
        staff.sort((a, b) => a[5].slice(1).replaceAll(',', '') - b[5].slice(1).replaceAll(',', ''));
        clicksSalary = 1;
    }
    else if (clicksSalary == 1) {
        staff.sort((a, b) => b[5].slice(1).replaceAll(',', '') - a[5].slice(1).replaceAll(',', ''));
        clicksSalary = 0;
    }
    displayStaff();
}

function displayStaff() {
    var table = document.getElementById('staffTable');
    staff.forEach(index => {
        table.deleteRow(-1);
    });
    staff.forEach(index => {
        var row = table.insertRow(-1);
        index.forEach(element => {
            var cell = row.insertCell(-1);
            cell.innerHTML = element;
        });
    });
}



//Functions for weather.html(Weather Page)
function converter(choice) {
    var c, f, k;
    var input = document.getElementById('inputTemp');
    var output = document.getElementById('tempOutput');
    output.innerHTML = "";
    if (choice == "doFahToCel") {
        f = parseFloat(input.value);
        c = Math.round((5 / 9 * (f - 32)) * 100) / 100;
    }
    else if (choice == "doCelToKel") {
        c = parseFloat(input.value);
        f = Math.round(((c * (9 / 5)) + 32) * 100) / 100;
    }
    k = () => Math.round((c + 273.15) * 100) / 100;
    output.innerHTML = "Celsius: " + c + "<br>Fahrenheit: " + f + "<br>Kelvin: " + k();
    input.value = "";
}

//Easter Egg
var count = 0;
function easterEgg(){
    switch(count){
        case 0:
            alert("Hey! You poked me!");
            break;
        case 1:
            alert("Ouch my nose!!");
            break;
        case 2:
            alert("Would you cut it out already!!");
            break;
        case 3:
            alert("I've had just about enough of you!!");
            break;
        case 4:
            alert("Alright buddy, this is the last time... I'm warning you!!");
            break;
        default:
            alert("That's it your done...");
            document.getElementById('photoOfMe').style.display = "none";
            break;       
    }
    count++;
}