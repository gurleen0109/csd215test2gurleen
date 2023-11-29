// For more information see https://aka.ms/fsharp-console-apps
// Define the discriminated union for the genre

type Genre = 
        | Horror 
        | Drama 
        | Thriller
        | Comedy 
        | Fantasy 
        | Sport

// Define the "Director" record type
type Director = {
  Name: string
  Movies: int
}

// Define the "Movie" record type
type Movie = {
  Name: string
  RunLength: int
  Genre: Genre
  Director: string
  IMDBRating: float
}

// Create movie instances

let movies = [
    { Name = "CODA"; RunLength = 111; Genre = Drama; Director = "Sian Heder"; IMDBRating = 8.1 }
    { Name = "Belfast"; RunLength = 98; Genre = Comedy; Director = "Kenneth Branagh"; IMDBRating = 7.3 }
    { Name = "Don't Look Up"; RunLength = 138; Genre = Comedy; Director = "Adam Mckay"; IMDBRating = 7.2 }
    { Name = "Dune"; RunLength = 155; Genre = Fantasy; Director = "Denis Villeneuve"; IMDBRating = 8.1 }
    { Name = "Drive My Car"; RunLength = 179; Genre = Drama; Director = "Ryusuke Hamaguchi"; IMDBRating = 7.6 }
    { Name = "King Richard"; RunLength = 144; Genre = Sport; Director = "Reinaldo Marcus Green"; IMDBRating = 7.5 }
    { Name = "Licorice Pizza"; RunLength = 133; Genre = Comedy; Director = "Paul Thomas Anderson"; IMDBRating = 7.4 }
    { Name = "Nightmare Alley"; RunLength = 150; Genre = Thriller; Director = "Guillermo Del Toro" ; IMDBRating = 7.1 }
]



// Identify probable Oscr winnrs
let oscrWinnrs = movies |> List.filter (fun movie -> movie.IMDBRating > 7.4)
printfn "oscrWinnrs: %A" oscrWinnrs