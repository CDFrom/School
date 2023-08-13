function myFunction() {
  let s = document.getElementById('txtInput').value;
  s = s.trim();
  while(s!=s.replace('  ',' '))
  {
    s=s.replace('  ',' ')
  }
  s = s.split(" ");
  for(let i in s){
    s[i] = s[i].toLowerCase().split('');
    s[i][0] = s[i].at(0).toUpperCase();
    s[i] = s[i].join('');
    // s[i] = s[i].slice(0,1).toUpperCase() + s[i].slice(1).toLowerCase();
  }
  s = s.reverse().join(", ");
  document.getElementById('outputDiv').style.display = "block";
  document.getElementById('txtResult').value = s;
}
