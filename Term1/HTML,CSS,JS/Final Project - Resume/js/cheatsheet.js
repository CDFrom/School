// Assign navigation bar values
let home = document.getElementById('Home');
let dom = document.getElementById('DOM');
let strings = document.getElementById('Strings');
let print = document.getElementById('Print');
let variables = document.getElementById('Variables');
let functions = document.getElementById('Functions');
let loops = document.getElementById('Loops');
let objects = document.getElementById('Objects');
let conversion = document.getElementById('Conversion');
let comparison = document.getElementById('Comparisons');
let dates = document.getElementById('Dates');

// On click function calls
home.onclick = showHome;
dom.onclick = showDOM;
strings.onclick = showStrings;
print.onclick = showPrint;
variables.onclick = showDeclarations;
functions.onclick = showFunctions;
loops.onclick = showLoops;
objects.onclick = showObjects;
conversion.onclick = showConversions;
comparison.onclick = showComparisons;
dates.onclick = showDates;


// Functions to change view
function showHome() {
  document.getElementsByClassName('home')[0].style.display = "block";
  document.getElementsByClassName('DOM')[0].style.display = "none";
  document.getElementsByClassName('strings')[0].style.display = "none";
  document.getElementsByClassName('print')[0].style.display = "none";
  document.getElementsByClassName('declarations')[0].style.display = "none";
  document.getElementsByClassName('functions')[0].style.display = "none";
  document.getElementsByClassName('loops')[0].style.display = "none";
  document.getElementsByClassName('objects')[0].style.display = "none";
  document.getElementsByClassName('conversions')[0].style.display = "none";
  document.getElementsByClassName('comparisons')[0].style.display = "none";
  document.getElementsByClassName('dates')[0].style.display = "none";
}

function showDOM() {
  document.getElementsByClassName('home')[0].style.display = "none";
  document.getElementsByClassName('DOM')[0].style.display = "block";
  document.getElementsByClassName('strings')[0].style.display = "none";
  document.getElementsByClassName('print')[0].style.display = "none";
  document.getElementsByClassName('declarations')[0].style.display = "none";
  document.getElementsByClassName('functions')[0].style.display = "none";
  document.getElementsByClassName('loops')[0].style.display = "none";
  document.getElementsByClassName('objects')[0].style.display = "none";
  document.getElementsByClassName('conversions')[0].style.display = "none";
  document.getElementsByClassName('comparisons')[0].style.display = "none";
  document.getElementsByClassName('dates')[0].style.display = "none";
}

function showStrings() {
  document.getElementsByClassName('home')[0].style.display = "none";
  document.getElementsByClassName('DOM')[0].style.display = "none";
  document.getElementsByClassName('strings')[0].style.display = "block";
  document.getElementsByClassName('print')[0].style.display = "none";
  document.getElementsByClassName('declarations')[0].style.display = "none";
  document.getElementsByClassName('functions')[0].style.display = "none";
  document.getElementsByClassName('loops')[0].style.display = "none";
  document.getElementsByClassName('objects')[0].style.display = "none";
  document.getElementsByClassName('conversions')[0].style.display = "none";
  document.getElementsByClassName('comparisons')[0].style.display = "none";
  document.getElementsByClassName('dates')[0].style.display = "none";
}

function showPrint() {
  document.getElementsByClassName('home')[0].style.display = "none";
  document.getElementsByClassName('DOM')[0].style.display = "none";
  document.getElementsByClassName('strings')[0].style.display = "none";
  document.getElementsByClassName('print')[0].style.display = "block";
  document.getElementsByClassName('declarations')[0].style.display = "none";
  document.getElementsByClassName('functions')[0].style.display = "none";
  document.getElementsByClassName('loops')[0].style.display = "none";
  document.getElementsByClassName('objects')[0].style.display = "none";
  document.getElementsByClassName('conversions')[0].style.display = "none";
  document.getElementsByClassName('comparisons')[0].style.display = "none";
  document.getElementsByClassName('dates')[0].style.display = "none";
}

function showDeclarations() {
  document.getElementsByClassName('home')[0].style.display = "none";
  document.getElementsByClassName('DOM')[0].style.display = "none";
  document.getElementsByClassName('strings')[0].style.display = "none";
  document.getElementsByClassName('print')[0].style.display = "none";
  document.getElementsByClassName('declarations')[0].style.display = "block";
  document.getElementsByClassName('functions')[0].style.display = "none";
  document.getElementsByClassName('loops')[0].style.display = "none";
  document.getElementsByClassName('objects')[0].style.display = "none";
  document.getElementsByClassName('conversions')[0].style.display = "none";
  document.getElementsByClassName('comparisons')[0].style.display = "none";
  document.getElementsByClassName('dates')[0].style.display = "none";
}

function showFunctions() {
  document.getElementsByClassName('home')[0].style.display = "none";
  document.getElementsByClassName('DOM')[0].style.display = "none";
  document.getElementsByClassName('strings')[0].style.display = "none";
  document.getElementsByClassName('print')[0].style.display = "none";
  document.getElementsByClassName('declarations')[0].style.display = "none";
  document.getElementsByClassName('functions')[0].style.display = "block";
  document.getElementsByClassName('loops')[0].style.display = "none";
  document.getElementsByClassName('objects')[0].style.display = "none";
  document.getElementsByClassName('conversions')[0].style.display = "none";
  document.getElementsByClassName('comparisons')[0].style.display = "none";
  document.getElementsByClassName('dates')[0].style.display = "none";
}

function showLoops() {
  document.getElementsByClassName('home')[0].style.display = "none";
  document.getElementsByClassName('DOM')[0].style.display = "none";
  document.getElementsByClassName('strings')[0].style.display = "none";
  document.getElementsByClassName('print')[0].style.display = "none";
  document.getElementsByClassName('declarations')[0].style.display = "none";
  document.getElementsByClassName('functions')[0].style.display = "none";
  document.getElementsByClassName('loops')[0].style.display = "block";
  document.getElementsByClassName('objects')[0].style.display = "none";
  document.getElementsByClassName('conversions')[0].style.display = "none";
  document.getElementsByClassName('comparisons')[0].style.display = "none";
  document.getElementsByClassName('dates')[0].style.display = "none";
}

function showObjects() {
  document.getElementsByClassName('home')[0].style.display = "none";
  document.getElementsByClassName('DOM')[0].style.display = "none";
  document.getElementsByClassName('strings')[0].style.display = "none";
  document.getElementsByClassName('print')[0].style.display = "none";
  document.getElementsByClassName('declarations')[0].style.display = "none";
  document.getElementsByClassName('functions')[0].style.display = "none";
  document.getElementsByClassName('loops')[0].style.display = "none";
  document.getElementsByClassName('objects')[0].style.display = "block";
  document.getElementsByClassName('conversions')[0].style.display = "none";
  document.getElementsByClassName('comparisons')[0].style.display = "none";
  document.getElementsByClassName('dates')[0].style.display = "none";
}

function showConversions() {
  document.getElementsByClassName('home')[0].style.display = "none";
  document.getElementsByClassName('DOM')[0].style.display = "none";
  document.getElementsByClassName('strings')[0].style.display = "none";
  document.getElementsByClassName('print')[0].style.display = "none";
  document.getElementsByClassName('declarations')[0].style.display = "none";
  document.getElementsByClassName('functions')[0].style.display = "none";
  document.getElementsByClassName('loops')[0].style.display = "none";
  document.getElementsByClassName('objects')[0].style.display = "none";
  document.getElementsByClassName('conversions')[0].style.display = "block";
  document.getElementsByClassName('comparisons')[0].style.display = "none";
  document.getElementsByClassName('dates')[0].style.display = "none";
}

function showComparisons() {
  document.getElementsByClassName('home')[0].style.display = "none";
  document.getElementsByClassName('DOM')[0].style.display = "none";
  document.getElementsByClassName('strings')[0].style.display = "none";
  document.getElementsByClassName('print')[0].style.display = "none";
  document.getElementsByClassName('declarations')[0].style.display = "none";
  document.getElementsByClassName('functions')[0].style.display = "none";
  document.getElementsByClassName('loops')[0].style.display = "none";
  document.getElementsByClassName('objects')[0].style.display = "none";
  document.getElementsByClassName('conversions')[0].style.display = "none";
  document.getElementsByClassName('comparisons')[0].style.display = "block";
  document.getElementsByClassName('dates')[0].style.display = "none";
}

function showDates() {
  document.getElementsByClassName('home')[0].style.display = "none";
  document.getElementsByClassName('DOM')[0].style.display = "none";
  document.getElementsByClassName('strings')[0].style.display = "none";
  document.getElementsByClassName('print')[0].style.display = "none";
  document.getElementsByClassName('declarations')[0].style.display = "none";
  document.getElementsByClassName('functions')[0].style.display = "none";
  document.getElementsByClassName('loops')[0].style.display = "none";
  document.getElementsByClassName('objects')[0].style.display = "none";
  document.getElementsByClassName('conversions')[0].style.display = "none";
  document.getElementsByClassName('comparisons')[0].style.display = "none";
  document.getElementsByClassName('dates')[0].style.display = "block";
}
