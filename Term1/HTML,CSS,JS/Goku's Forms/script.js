let num = 1;

function swap() {
  num++;
  if (num == 10) {
    num = 1;
  }
  document.getElementById('img').src = "img/" + num + ".jpg";
  let title = "12 Years Old"
  switch (num) {
    case 1:
      title = "12 Years Old";
      break;
    case 2:
    title = "Great Ape"
      break;
    case 3:
    title = "Pseudo Super Saiyan"
      break;
    case 4:
    title = "Super Saiyan"
      break;
    case 5:
    title = "Super Saiyan 2"
      break;
    case 6:
    title = "Super Saiyan 3"
      break;
    case 7:
    title = "Super Saiyan God"
      break;
    case 8:
    title = "Super Saiyan Blue"
      break;
    case 9:
    title = "Ultra Instinct"
      break;
  }
  document.getElementById('title').innerHTML = title;
}
