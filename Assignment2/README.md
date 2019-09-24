
Assignment 2 "Dollar Addresses"
Due Tuesday 2019-09-24

Assignment Goals
Student creates project that makes web calls, deserializes the response (xml or json), analyzes the data and outputs some result.
Code must be well organized.
Code must be configurable.
Code must be unit tested.
Estimated Time: 60 minutes (your mileage may vary)
FYI: If this assignment doesn't interest you, you may submit any project that meets the assignment goals above. It must be your original work, done for this class and include a README file describing the project and demonstrating the input/output. Your project must be interesting.

Context
"Dollar addresses" are street addresses where the house number is the "cost" of the street. "Cost" of a street is the sum of the letters in the streetName and streetSuffix (a=1, b=2 etc). Example: "71 High St" Your goal is to output all street names in your home town (or some town in Maine if you're "from away") that have a dollar address.

Directions
Add an "Assignment2" folder to your repo
Create a new command line application in that folder
Make your program
Fetch all addresses in your home town from "the API"
Deserialize the response
Filter the addresses to only include where the house number = "cost" of the street name.
Or, I don't know, do some other interesting data analysis.
List the street names of those addresses to Console
Make your program configurable
Identify any parameters that your boss is likely to change
DO NOT HARD CODE those parameters, instead put them in a config file
Add unit tests
Unit test any tricky functions that don't touch other resources (don't unit test IO operations)
Commit Code and some proof of the output, push it to github.
"The API":
A description of the data set
An Example Query
Change "Format" from "HTML" to "JSON" to get just the data.
Note: this is a government API, be nice to it.
Something I didn't tell you: The API only return a maximum of 5000 records per request. You could make more requests and set the 'resultOffset' value to get the next 5000 records but I'm afraid of what a mis-coded loop could do. Just work with the first 5000 results that you get from the first call.
Hints
I've added demonstrations of these ideas in my notes folder.
