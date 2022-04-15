

function getAll(){
    const allSongsApiURL = "https://localhost:7264/api/songs";

    fetch(allSongsApiURL).then(function(response){
        console.log(allSongsApiURL)
        return response.json();
    }).then(function(json){
        console.log(allSongsApiURL)
        let html = ``;
            json.forEach((song) =>{

        html += `<div id = "cards" class="card col-md-4 bg-dark text-white">`;
			    html += `<img src="./jpegs/music.jpeg" class="card-img" alt="a music note ontop of the selection card">`;
			    html += `<div class="card-img-overlay">`;
			    html += `<h5 class="card-title">`+song.songTitle+`</h5>`;
            html += `</div>`;
        html += `</div>`;
        });

        if(html === ``){
            html = "No Songs found :("
        }
		document.getElementById("allSongs").innerHTML = html;

	})
    .catch(function(error){
        console.log(error);
    });
}

function create(){
    const postSongApiURL = "https://localhost:7264/api/songs";  
    const SongTitle = document.getElementById("songTitle").value


    const title = {
        SongTitle: document.getElementById("songTitle").value}
    console.log(title);
        
    fetch(postSongApiURL, {
        method: "POST",
        headers: {
            "Accept": 'application/json',
            "Context-Type": 'application/json'
        },
        body: JSON.stringify(title)
    })
    .then((response)=>{
        console.log(response);
        getAll();
    }).catch(function(error){
        console.log(error);
    });
    
}

function deleteSong(){
    let id = document.getElementById("delete").value;
    const deleteSongApiURL = "https://localhost:7264/api/songs";+id;

    fetch(deleteSongApiURL, {
        method: "DELETE",
        headers: {
            "Content-Type": 'application/json'
        },
    })
    .then((response)=>{
        console.log(response);
        getSongs();
    }).catch(function(error){
        console.log(error);
    });
}

function favoriteSong(){
    let id = document.getElementById("favorited").value;
    const favoriteSongApiURL = "https://localhost:7264/api/songs";+id;

    fetch(deleteSongApiURL, {
        method: "PUT",
        headers: {
            "Content-Type": 'application/json'
        },
    })
    .then((response)=>{
        console.log(response);
        getSongs();
    }).catch(function(error){
        console.log(error);
    });
}