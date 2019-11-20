<<<<<<< HEAD
function getButtonIndex(index){
    var clickedIndex;

    $('.category-button').click(function(){
        clickedIndex = $('.category-button').index(this);
    });
    
    
    return clickedIndex;
}

function setElementTextById(id,num){
    document.getElementById(id).innerText = "fafam";

=======
function getButtonIndex(){
    

    $('.category-button').click(function(){
        alert( $('.category-button').index(this) );
    });
    
    var clickedIndex = $('.category-button').index(this);
    return clickedIndex;
>>>>>>> 6f49a51a5d3aeb241d10ece2d50fabb0b33ef04a
}