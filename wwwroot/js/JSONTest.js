//create the request in ajax
let http = new XMLHttpRequest(); 
http.open('get', '../movies-2010s.json', true); 
http.send(); 


http.onload = function(){
    if(this.readyState == 4 && this.status == 200){
        //parse the json file 
        var movies = JSON.parse(this.responseText);
        var outputTopPick = "";
        var outputHorror = "";
        var outputComedy = ""; 
        var outputRomance = "";  
        let x = 0; 
        
        //loop for posting Top Movies
        for(let item of movies){
            if('thumbnail' in item){
                outputTopPick += `
                <div class="top-picks">
                     <img class = "moviePoster" src=${ item.thumbnail } alt="some-movie">
                            <div class="top-name">
                                <p>${ item.title }</p>
                            </div>
                </div>
                `;
                document.getElementById('top-picks').innerHTML = outputTopPick; 
                x++;
                if (x == 24){
                    x = 0; 
                    break; 
                }
            }
            
        }
        
        //loop for posting Horror Movies
        for(let item of movies){ //for every item of movies we loop through
            if('genres' in item){ //does it contain a genres
                if('thumbnail' in item){
                    for(var i = 0; i < item.genres.length; i++){ //if it does, loop through the array of genres
                    
                        if(item.genres[i] == 'Horror'){ //if one of the entries is horror then we will go ahead and do output 
                            
    
                            outputHorror += `
                                <div class="horror">
                                    <img class = "moviePoster" src=${ item.thumbnail } alt="some-movie">
                                        <div class="horror-name">
                                            <p>${ item.title }</p>
                                        </div>
                                </div>
                            `;
                            
                        }
                    }
                } else {
                    console.log('this is x: ' + x);
                document.getElementById('horror').innerHTML = outputHorror; 
                x++; 
                if(x == 24){
                    x = 0; 
                    break; 
                }
                    continue; 
                }
                
                
                
                
            }
        }
        
        //loop for posting Comedy movies
        for(let item of movies){

        }
        
        //loop for posting Romance movies
        for(let item of movies){
            
        }
      
    }
}
