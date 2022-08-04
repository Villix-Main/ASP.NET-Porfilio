// ways to get elements 

// GetElementById()
const title = document.getElementById('main-heading');

// GetElementByClassName()
const listItem = document.getElementsByClassName('list-items')

// GetElementByTagName() tag name = <html>, <h2>...
// const listItem = document.getElementsByTagName('li')

// querySelector()
const container = document.querySelector('div');
console.log(container);

// querySelectorAll()
const containerAll = document.querySelectorAll('div');
console.log(container);


// Styling elements
const pageTitle = document.querySelector("#main-heading");

// This is inline styling which can only be applied to one element
// To apply to more than one element, use for loop
pageTitle.style.color = 'red';

const listItems = document.querySelectorAll('.list-items') 
for (i = 0; i < listItems.length; i++) 
{
    listItems[i].style.color = 'green';
}


// Creating Elements

const ul = document.querySelector('ul');
const li = document.createElement('li');

// Adding Elements
ul.append(li)

// Modifying the text

