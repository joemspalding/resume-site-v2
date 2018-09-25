
var errorHelper = (function ($) {
	"use strict";
	var module = {
		onready: function () {
			genres = getGenres();
			stories = getStories();

			//check to see if props are initialized code from slack
			bindMusicGeneratorClick();
		}
	};
	return module;

	var genres;
	var stories;

	function bindMusicGeneratorClick() {
		$("#makeMusicalString").on('click', function () {
			let genre = getRandomArrayEle(genres);
			let storyType = 'classics';
			let story = getRandomArrayEle(stories[storyType]);

			let storyMade = makeStoryString(genre, storyType, story)

			$("#article").text(getArticle(genre));
			$("#genre").text(genre);
			$("#story").text(story);
			console.log(storyMade);
		});
	}


	// Returns spotify list of genres
	function getGenres() {
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

	function getStories() {
		return {
			// people: getPeopleStories(),
			classics: getClassicStories()
		};

	}
	// Returns an array of novels and stories
	function getClassicStories() {
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

	function makeStoryString(genre, storyType, story) {
		return `A ${genre} interpretation of ${story}`
	}

	function getArticle(genre) {
		var vowels = ['a', 'e', 'i', 'o', 'u'];
		for (var i = 0; i < vowels.length; i++) {
			if (genre[0] === vowels[i]) {
				return 'An';
			}
		}

		return 'A';
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



})(jQuery);
