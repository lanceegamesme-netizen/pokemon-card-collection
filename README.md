# Pokémon Card Collection (Razor Pages)

A small beginner-level ASP.NET Core Razor Pages website inspired by the Microsoft Learn series **Get started with Razor Pages in ASP.NET Core**, through Part 5.

It uses a local SQLite database and includes card photos loaded from the web.

## What is included

- Home page
- List cards and search by card name
- Add a card
- View card details
- Edit a card
- Delete a card
- SQLite local database (`pokecards.db`)
- Six sample cards to make the site look populated when it first runs

## Requirements

- Visual Studio 2022
- The **ASP.NET and web development** workload
- .NET 8 SDK
- Internet connection to load the sample card photos

## Run the project in Visual Studio

1. Extract this ZIP file.
2. Open Visual Studio 2022.
3. Select **Open a project or solution**.
4. Open `PokeCardCollection.csproj` from the extracted folder.
5. Wait for Visual Studio to restore the NuGet package.
6. Press **Ctrl + F5** to run without debugging.
7. Open **My Cards** to view the sample collection.

The app creates `pokecards.db` automatically in the app's working folder the first time it starts. New, edited, and deleted cards are saved in that file.

## Run from the terminal

Open a terminal in the folder that contains `PokeCardCollection.csproj`, then run:

```bash
dotnet restore
dotnet run
```

Open the local URL printed in the terminal.

## How this follows the Microsoft Learn beginner steps

1. **Create a Razor Pages app** — `Program.cs`, `Pages`, and the shared layout set up the site.
2. **Add a model** — `Models/PokemonCard.cs` describes each card and its fields.
3. **Create Razor Pages** — `Pages/Cards` contains the list, details, create, edit, and delete pages.
4. **Work with a database** — `Data/CardContext.cs` connects the model to SQLite through Entity Framework Core.
5. **Update the pages** — the pages show card details and let you manage the collection.

This project is a Pokémon-card adaptation of the learning sequence, not a copy of Microsoft's movie sample.

## Adding card photos

The sample photos use public Pokémon TCG image URLs. You can paste another direct image URL into the **Card image URL** field when creating or editing a card. Since the photos are loaded from the internet, they need an internet connection to display.

## Notes

- The app uses `EnsureCreated()` to keep the first setup simple for a beginner project.
- If you change the database model later, back up your data before deleting `pokecards.db` and allowing the app to recreate it.
- Prices are example values for the demo only, not live market prices.
