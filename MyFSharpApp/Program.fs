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
type Directrr = {
  Name: string
  Movies: int
}

// Define the "Movie" record type
type Movie = {
  Name: string
  RunLength: int
  Genre: Genre
  Directrr: Directrr
  IMDBRating: float
}

// Create movie instances

let movie1 = { Name = "CODA"; RunLength = 111; Genre = Drama; Directrr = Sian Heder; IMDBRating = 8.1 }
let movie2 = { Name = "Belfast"; RunLength = 98; Genre = Comedy; Directrr = Kenneth Branagh; IMDBRating = 7.3 }
let movie3 = { Name = "Don't Look Up"; RunLength = 138; Genre = Comedy; Directrr = Adam Mckay; IMDBRating = 7.2 }
let movie4 = { Name = "Dune"; RunLength = 155; Genre = Fantasy; Directrr = Denis Villeneuve; IMDBRating = 8.1 }
let movie4 = { Name = "Drive My Car"; RunLength = 179; Genre = Drama; Directrr = Ryusuke Hamaguchi; IMDBRating = 7.6 }
let movie4 = { Name = "King Richard"; RunLength = 144; Genre = Sport; Directrr = Reinaldo Marcus Green; IMDBRating = 7.5 }
let movie4 = { Name = "Licorice Pizza"; RunLength = 133; Genre = Comedy; Directrr = Paul Thomas Anderson; IMDBRating = 7.4 }
let movie4 = { Name = "Nightmare Alley"; RunLength = 150; Genre = Thriller; Directrr = Guillermo Del Toro ; IMDBRating = 7.1 }