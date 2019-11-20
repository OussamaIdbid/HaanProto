function getButtonIndex(index){
    var clickedIndex;

    $('.category-button').click(function(){
        clickedIndex = $('.category-button').index(this);
    });
    
    
    return clickedIndex;
}

function setElementTextById(id,num){
    document.getElementById(id).innerText = "fafam";

}