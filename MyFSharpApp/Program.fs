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
  Movies: number
}
