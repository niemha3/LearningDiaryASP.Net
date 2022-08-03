// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


const instructionButton = document.getElementById("instructionBtn")
const instructionSpace = document.getElementById("instructions");
instructionButton.addEventListener('click', ShowInstructions);

function ShowInstructions() {
   
    let instructionsText = document.createElement("div");
    //Styles
    instructionsText.style.backgroundColor = 'white';
    instructionsText.style.width = '600px';
   
    instructionsText.style.padding = '20px';
    instructionsText.style.height = '110px';
    instructionsText.style.borderRadius = '10px';
    instructionsText.style.textAlign = 'center';

    //Content
    instructionsText.textContent = "Search topics with an Id with the searchbar. By clicking Topics from the navigation, you will be able to create, edit, delete or show all topics";

    instructionSpace.appendChild(instructionsText);

    // Button to close instructions

    let closeBtn = document.createElement("button");
    closeBtn.appendChild(document.createTextNode("Close instructions"));
    closeBtn.style.marginTop = '5px';
    closeBtn.style.border = 'solid 1px';

    instructionsText.appendChild(closeBtn);

    closeBtn.addEventListener('click', function () {
        instructionsText.style.display = 'none';
      
    })


}


// Scroll function
function scrollIntoView() {
    document.getElementById("topics").scrollIntoView({
        behavior: 'smooth'
    });
}
