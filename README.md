# Repeat Counter

#### By Ben Logue, Current as of June 9, 2016

## Description

This app takes in a sentence and a word from a user and then returns a count of the unique instances of that word in the given sentence. The word search is case insensitive, ignores punctuation following word, and does not count partial matches.

|Behavior    |Input   |Output   |
|---|---|---|
|user inputs a sentence with no matching instances of word  | sentence: "the quick brown fox", word: "dog"  | Matches: 0  |
|user inputs a sentence with a single matching instance of word |sentence: "the quick brown fox", word: "fox"  | Matches: 1  |
|user inputs a sentence with multiple instances of matching word | sentence: "the quick brown fox fox" word: "fox" | Matches: 2  |
|user inputs a sentence with multiple matching instances of word in different cases  |sentence: "the quick brown FOX fox fOx"  | Matches: 3   |
|user inputs sentence with instances of partial matching word and matching word  | sentence: "the quick brown fox does the foxtrot" word: "fox"  | Matches: 1  |
|user inputs a sentence with instance of word followed by punctuation  | sentence: "the quick brown fox.", word: "fox"  | Matches: 1  |


## Setup/Installation Requirements

* Clone the github repository.
* Navigate to directory in PowerShell.
* Enter commands 'dnu restore' and 'dnx kestrel' to initialize local host.
* Open http://localhost:5004 in browser.

## Known Bugs

None.  

## Support and contact details

benjamin.logue73@gmail.com

## Technologies Used

* C#
* Nancy and Razor
* Xunit for testing

### License

Licensed under the MIT License

Copyright (c) 2016 **Ben Logue**
