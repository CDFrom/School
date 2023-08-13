function myFunction() {
  let input = document.getElementById('myTxtInput').value;
  let firstLast = input.split(' ');
  if (input == "" || firstLast.length != 2) {
    alert("Please enter first and last name thank you!");
    document.getElementById('myTxtInput').value = "";
  } else {
    document.getElementById('outputDiv').style.display = "block";
    document.getElementById('myTxtResult').value = firstLast[0].slice(0,1).toUpperCase()+". "+firstLast[1].slice(0,1).toUpperCase()+firstLast[1].slice(1).toLowerCase();
  }
}
