function getButtonIndex(){
    

    $('.category-button').click(function(){
        alert( $('.category-button').index(this) );
    });
    
    var clickedIndex = $('.category-button').index(this);
    return clickedIndex;
}