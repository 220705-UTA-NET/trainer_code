'use strict';


// AJAX - Asynchronous JavaScript and XML

// these are the elements that the DOM has for us to interact with...

document.addEventListener('DOMContentLoaded', () =>
{
    const listContainer = document.getElementById('list-container');
    const loadUsers = document.getElementById('load-users');
    const dataInput = document.getElementById('data-input');


    loadUsers.addEventListener('click', () =>
    {
        
        if(dataInput.value > 10)
        {
            let html = "<h3>There are only 10 users</h3>";
            listContainer.innerHTML = html;
            return;
        }

        // let url = "https://jsonplaceholder.typicode.com/users/" + dataInput.value;
        let url = "https://demowebapp-hawkins-220705.azurewebsites.net/api/Associates";

        fetch(url)
            .then(response => 
            {
                if(!response.ok)
                {
                    throw new Error(`server response: ${response.status}`);
                }
                return response.json();
            })
            .then(obj =>
            {
                displayData(obj, listContainer);
            })
            .catch(err =>
            {
                console.log(err);
                listContainer.innerHTML = `<h3>${err}</h3>`;
            })
        
    //     const req = new XMLHttpRequest();
    //     console.log(req.readyState);

    //     // requestObject.open(method, url, async)
    //     req.open("GET", url, true);
    //     console.log(req.readyState);
        
    //     req.setRequestHeader("Accept", "application/json");
        
    //     req.onload = function() 
    //     {
    //         if (req.status === 200)
    //         {
    //             let html = "<ul>";
    //             console.log(req.readyState);
    //             let response = JSON.parse(req.responseText);
    //             // console.log(req.responseText);
    //             // console.log(response);

    //             if(!(response instanceof Array))
    //             { 
    //                 response = [response];
    //             }



    //             for (let item in response)
    //             {
    //                 console.log(response[item].name);
    //                 html += `<li>${response[item].name}</li>`; 
    //                 // use back-ticks (shift + ~) to use template literals
    //             }
    //             html += "</ul>";
    //             listContainer.innerHTML = html;
    //         }
    //         else
    //         {
    //             console.log("Bad response. Error");
    //         } 
    //     }

    //     try{
    //     req.send();
    //     }
    //     catch(e)
    //     {
    //         console.log(e);
    //     }
     })
})


function displayData(data, container)
{
    if(!(data instanceof Array))
    {
        data = [data];
    }

    let html = '<ul>' + data.map(x => '<li>' + x.name + '</li>').join(' ') + '</ul>';
    container.innerHTML = html;
}
























// XMLHttpRequest - used to make HTTP requests to a server
// XMLHttpRequest.readyState - the state of the request
// 0-4, unsent, opened, headers received, loading, done












    // if (req.readyState === 4)
    // {
    //     if (req.status === 200)
    //     {
    //         console.log(req.readyState);
    //         console.log(req.responseText);
    //     }
    //     else
    //     {
    //         console.log("Error");
    //     }
    // }
    // else
    // {
    //     console.log("pending");
    // }






// if(req.readystate < 4)
// {
//     console.log("loading...");
// }
// else{
//    // req.onreadystatechange = function()
// }






// After AJAX, we send the data to the DOM

// DOM = Document Object Model
