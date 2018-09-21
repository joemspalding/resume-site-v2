
var genres;
var stories;



function pageLoad() {
	genres = getGenres();
	stories = getStories();
	document.getElementById("mainHolder").addEventListener("click", makeStory);
	// makeStory();
}

// Returns spotify list of genres
function getGenres() {
	//Maybe one day ill use the spotify genre api, but that seems dumb lol
	const url = 'https://api.spotify.com/v1/recommendations/available-genre-seeds';
	const spotifyAuth = "BQBHONGE-V80KKnagBqta13hk2omQOoxAx2KV5k-G0awkTUZzsvAw5j4TQukquQ5gj55s-p0NUX-FLQC5urNeYhu5kNcQp5pWtiguXuCG5YhZnVjy14jra77prTQ_UwNVb3gJGuXxuI"

	//A heavily modified version of the spotify genre api
	return [
		"acoustic",
		"afrobeat",
		"alt-rock",
		"alternative",
		"anime",
		"black-metal",
		"bluegrass",
		"blues",
		"bossanova",
		"breakbeat",
		"classical",
		"club",
		"country",
		"dance",
		"dancehall",
		"death-metal",
		"disco",
		"disney",
		"drum-and-bass",
		"dubstep",
		"edm",
		"electro",
		"electronic",
		"emo",
		"folk",
		"funk",
		"gospel",
		"goth",
		"grindcore",
		"groove",
		"grunge",
		"hard-rock",
		"hardcore",
		"hardstyle",
		"heavy-metal",
		"hip-hop",
		"holidays",
		"house",
		"indie",
		"indie-pop",
		"industrial",
		"j-pop",
		"jazz",
		"k-pop",
		"latin",
		"metal",
		"metalcore",
		"new-age",
		"opera",
		"party",
		"pop",
		"power-pop",
		"psych-rock",
		"punk rock",
		"r-n-b",
		"reggae",
		"rock",
		"rock-n-roll",
		"rockabilly",
		"romance",
		"sad",
		"salsa",
		"samba",
		"show-tunes",
		"ska",
		"soul",
		"synth-pop",
		"tango",
		"techno",
		"trance",
		"trip-hop",
		"world-music"
	];
}

// Will connect to an api to get famous historical figures and novels
function getStories() {
	return {
		// people: getPeopleStories(),
		classics: getClassicsStories()
	};

}

// Returns an array of prominent and interesting historical figures
function getPeopleStories() {
	//TODO: Find an api for interesting historical figures
	return ['Emperor Justinian', 'Oda Nobunaga'];
}

// Returns an array of novels and stories
function getClassicsStories() {
	// NYTimes bestseller list. Filtered out a lot of the ones that werent stories
	//  ie. 7 habits of highly effective people
	return [
		"A Tale of Two Cities",
		"The Lord of the Rings",
		"Le Petit Prince (The Little Prince)",
		"Harry Potter and the Philosopher's Stone",
		"The Hobbit",
		"And Then There Were None",
		"Dream of the Red Chamber",
		"Alice's Adventures in Wonderland",
		"The Lion, the Witch and the Wardrobe",
		"She: A History of Adventure",
		"The Adventures of Pinocchio",
		"The Da Vinci Code",
		"Harry Potter and the Chamber of Secrets",
		"Harry Potter and the Prisoner of Azkaban",
		"Harry Potter and the Goblet of Fire",
		"Harry Potter and the Order of the Phoenix",
		"Harry Potter and the Half-Blood Prince",
		"Harry Potter and the Deathly Hallows",
		"The Catcher in the Rye",
		"The Adventures of Sherlock Holmes",
		"Lolita",
		"Charlotte's Web",
		"The Mark of Zorro",
		"The Tale of Peter Rabbit",
		"The Odyssey",
		"The Very Hungry Caterpillar",
		"To Kill a Mockingbird",
		"War and Peace",
		"The Diary of Anne Frank",
		"The Kite Runner",
		"Gone with the Wind",
		"1984",
		"The Girl with the Dragon Tattoo",
		"The Great Gatsby",
		"The Hunger Games",
		"The Fault in Our Stars",
		"The Godfather",
		"All Quiet on the Western Front",
		"Things Fall Apart",
		"Animal Farm",
		"Jaws",
		"The Adventures of Huckleberry Finn",
		"Pride and Prejudice",
		"Where the Wild Things Are",
		"Dune",
		"Charlie and the Chocolate Factory",
		"The Neverending Story",
		"The Grapes of Wrath",
		"The Hitchhiker's Guide to the Galaxy",
		"A Wrinkle in Time",
		"Divine Comedy",
		"The Exorcist",
		"The Cat in the Hat",
		"The Help",
		"Catch-22",
		"Life of Pi",
		"The Giver",
		"The Goal",
		"Farenheit 451",
		"Romance of the Three Kingdoms",
		"Schindler's List"
	]
}

function makeStory(e) {
	let genre = getRandomArrayEle(genres);
	//let storyType = pickRandomProperty(stories);
	let storyType = 'classics';
	let story = getRandomArrayEle(stories[storyType]);

	var storyMade = makeStoryString(genre, storyType, story)

	document.getElementById("genre").textContent = genre;
	//document.getElementById("storyType").textContent = storyType == "people" ?  " the life of" : "";
	document.getElementById("story").textContent = story;

	console.log(storyMade)
}

function makeStoryString(genre, storyType, story) {
	return `A ${genre} interpretation of${storyType == "people" ? " the life of" : ""} ${story}`
}

function getRandomArrayEle(array) {
	return array[Math.floor(Math.random() * array.length)]
}

function pickRandomProperty(obj) {
	var result;
	var count = 0;
	for (var prop in obj)
		if (Math.random() < 1 / ++count)
			result = prop;
	return result;
}