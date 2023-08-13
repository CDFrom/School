// Assign navigation bar values
let bio = document.getElementById('MyBio');
let resume = document.getElementById('MyResume');
let contact = document.getElementById('ContactMe');
let games = document.getElementById('navGames');
let film = document.getElementById('navFilm');
let fantasy = document.getElementById('navFantasy');

// Check for null to avoid errors
if (bio != null) {
  bio.onclick = showBio;
}
if (resume != null) {
  resume.onclick = showResume;
}
if (contact != null) {
  contact.onclick = showContact;
}
if (games != null) {
  games.onclick = showGames;
}
if (film != null) {
  film.onclick = showFilm;
}
if (fantasy != null) {
  fantasy.onclick = showFantasy;
}

// Functions to change view
function showBio() {
  document.getElementById('BioSection').style.display = "block";
  document.getElementById('ResumeSection').style.display = "none";
  document.getElementById('ContactSection').style.display = "none";
  document.body.style.backgroundImage = "url('./Images/pexels-matt-hardy-3560168.jpg')";
}

function showResume() {
  document.getElementById('BioSection').style.display = "none";
  document.getElementById('ResumeSection').style.display = "block";
  document.getElementById('ContactSection').style.display = "none";
  document.body.style.backgroundImage = "url('./Images/pexels-johannes-plenio-1103970.jpg')";
}

function showContact() {
  document.getElementById('BioSection').style.display = "none";
  document.getElementById('ResumeSection').style.display = "none";
  document.getElementById('ContactSection').style.display = "block";
  document.body.style.backgroundImage = "url('./Images/pexels-james-wheeler-417074.jpg')";
}

function showGames() {
  document.getElementById('games').style.display = "block";
  document.getElementById('film').style.display = "none";
  document.getElementById('fantasy').style.display = "none";
  document.body.style.backgroundImage = "url('./Images/Games/pexels-pixabay-278918.jpg')";
}

function showFilm() {
  document.getElementById('games').style.display = "none";
  document.getElementById('film').style.display = "block";
  document.getElementById('fantasy').style.display = "none";
  document.body.style.backgroundImage = "url('./Images/Film/pexels-pietro-jeng-65128.jpg')";
}

function showFantasy() {
  document.getElementById('games').style.display = "none";
  document.getElementById('film').style.display = "none";
  document.getElementById('fantasy').style.display = "block";
  document.body.style.backgroundImage = "url('./Images/Fantasy/pexels-eberhard-grossgasteiger-844297.jpg')";
}
