function square() {
  var input=document.getElementById("number").value;
  parseInt(input);
  var output=input**2;
  document.getElementById("result").value=output;
  document.getElementById('lower').style.display='block';
}
