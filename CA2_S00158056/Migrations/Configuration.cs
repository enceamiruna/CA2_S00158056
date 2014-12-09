namespace CA2_S00158056.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using CA2_S00158056.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<CA2_S00158056.Models.CA2Entities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "CA2_S00158056.Models.CA2Entities";
        }

        protected override void Seed(CA2_S00158056.Models.CA2Entities context)
        {
            context.Movies.AddOrUpdate(new Movie()
            {
                movieID = 1,
                movieName = "The Hunger Games",
                description = @"Metascore: 64/100 (44 reviews)

When Katniss destroys the games, she goes to District 13 after District 12 is destroyed. She meets President Coin who convinces her to be the symbol of rebellion, while trying to save Peeta from the Capitol.There's been a bit of critical rebellion against this, the penultimate chapter of The Hunger Games movie franchise, which has been making me laugh since the story has been called too talky by some of the same reviewers who dismiss summer blockbusters for their lack of narrative and character development.",
                imageUrl = "Movie1.jpg"
            });
            context.Movies.AddOrUpdate(new Movie()
            {
                movieID = 2,
                movieName = "Happy Valley",
                description = @"Metascore: 75/100 (13 reviews)

A documentary that observes the year after Pennsylvania State University assistant football coach Jerry Sandusky's arrest on child sex abuse charges.Documentarian Amir Bar-Lev has courted controversy before with The Tillman Story and My Kid Could Paint That, so we're expecting his profile to rise with his look at the charges against Jerry Sandusky, which dated back to 2008 and ended with his indictment on November 2011.",
                imageUrl = "Movie2.jpg"
            });
            context.Movies.AddOrUpdate(new Movie()
            {
                movieID = 3,
                movieName = "The theory of everything",
                description = @"Metascore: 72/100 (44 reviews)

  A look at the relationship between the famous physicist Stephen Hawking and his wife.While I certainly am familiar with the theories and work of scientist Stephen Hawking, I have never known much about his personal history and so I was immediately interested in seeing a biopic on his life. One of the reasons I'm most excited about the film is the fact that it focuses on the relationship between Stephen and Jane Hawking, and is based on her original book. For me, there's nothing better than a good love story. There's already a ton of Oscar buzz about Eddie Redmayne's performance in the film and I already have my fingers crossed for him.",
                imageUrl = "Movie3.jpg"
            });
            context.Movies.AddOrUpdate(new Movie()
            {
                movieID = 4,
                movieName = "The Sleepwalker",
                description = @"Metascore: 57/100 (7 reviews)

A young couple, Kaia and Andrew, are renovating Kaia's secluded family estate. Their lives are violently disrupted upon the unexpected arrival of Kaia's sister, Christine, and her fiancé, Ira.",
                imageUrl = "Movie4.jpg"
            });
            context.Movies.AddOrUpdate(new Movie()
            {
                movieID = 5,
                movieName = "V/H/S: Viral",
                description = @"Metascore: 31/100 (6 reviews)

Follows fame-obsessed teens who unwittingly become stars of the next internet sensation.The general fan consensus is pretty negative toward the third and final installment of the V/H/S franchise, a saga that seemed to challenge its filmmakers with certain constraints (low budgets and quick turnarounds) in order to keep its trademark on the resurgent horror-anthology trend. The barebones approach is what made us appreciate these stories, no matter how unnerving they were, but we were less entertained by this world the more we learned about it.",
                imageUrl = "Movie5.jpg"
            });
            context.Movies.AddOrUpdate(new Movie()
            {
                movieID = 6,
                movieName = "Extraterrestrial",
                description = @"Metascore: 38/100 (12 reviews)

A group of friends on a weekend trip to a cabin in the woods find themselves terrorized by alien visitors.Filmmaking duo The Vicious Brothers pleased genre fans with their debut, Grave Encounters, and returned as screenwriters for its sequel, and now they look to augment the cabin-in-the-woods scenario with an alien invaders. The movie has been on VOD for over a month so chances are its core audience has already seen it, but we're interested to see where they take this story and what they get into with their next project.",
                imageUrl = "Movie6.jpg"
            });

            context.Actors.AddOrUpdate(new Actor() { actorID = 1, actorName = "Jennifer Lawrence",description= @"This is an actor and there is so much to talk about them

his is an actor and there is so much to talk about them

his is an actor and there is so much to talk about them"
            });
            context.Actors.AddOrUpdate(new Actor()
            {
                actorID = 2,
                actorName = "Josh Hutcherson",
                description = @"This is an actor and there is so much to talk about them

his is an actor and there is so much to talk about them

his is an actor and there is so much to talk about them"
            });
            context.Actors.AddOrUpdate(new Actor()
            {
                actorID = 3,
                actorName = "Liam Hemsworth",
                description = @"This is an actor and there is so much to talk about them

his is an actor and there is so much to talk about them

his is an actor and there is so much to talk about them"
            });
            context.Actors.AddOrUpdate(new Actor()
            {
                actorID = 4,
                actorName = "Donald Sutherland",
                description = @"This is an actor and there is so much to talk about them

his is an actor and there is so much to talk about them

his is an actor and there is so much to talk about them"
            });
            context.Actors.AddOrUpdate(new Actor()
            {
                actorID = 5,
                actorName = "Paul AnnoyingPerson",
                description = @"This is an actor and there is so much to talk about them

his is an actor and there is so much to talk about them

his is an actor and there is so much to talk about them"
            });
            context.Actors.AddOrUpdate(new Actor()
            {
                actorID = 6,
                actorName = "Maggie CodeQueen",
                description = @"This is an actor and there is so much to talk about them

his is an actor and there is so much to talk about them

his is an actor and there is so much to talk about them"
            });
            context.Actors.AddOrUpdate(new Actor()
            {
                actorID = 7,
                actorName = "Cats AreNice",
                description = @"This is an actor and there is so much to talk about them

his is an actor and there is so much to talk about them

his is an actor and there is so much to talk about them"
            });
            context.Actors.AddOrUpdate(new Actor()
            {
                actorID = 8,
                actorName = "Willow Shields",
                description = @"This is an actor and there is so much to talk about them

his is an actor and there is so much to talk about them

his is an actor and there is so much to talk about them"
            });
            context.Actors.AddOrUpdate(new Actor()
            {
                actorID = 9,
                actorName = "Mahershala Ali",
                description = @"This is an actor and there is so much to talk about them

his is an actor and there is so much to talk about them

his is an actor and there is so much to talk about them"
            });
            context.Actors.AddOrUpdate(new Actor()
            {
                actorID = 10,
                actorName = "Stanley Tucci",
                description = @"This is an actor and there is so much to talk about them

his is an actor and there is so much to talk about them

his is an actor and there is so much to talk about them"
            });
            context.Actors.AddOrUpdate(new Actor()
            {
                actorID = 11,
                actorName = "Dogs Are NotAsNiceAsCats",
                description = @"This is an actor and there is so much to talk about them

his is an actor and there is so much to talk about them

his is an actor and there is so much to talk about them"
            });

            context.ScreenNames.AddOrUpdate(new ScreenName() { movieID = 1, actorID = 1, screenName = "Katniss Everdeen" });
            context.ScreenNames.AddOrUpdate(new ScreenName() { movieID = 2, actorID = 1, screenName = "The Cat Lady" });
            context.ScreenNames.AddOrUpdate(new ScreenName() { movieID = 1, actorID = 2, screenName = "Peeta Mellark" });
            context.ScreenNames.AddOrUpdate(new ScreenName() { movieID = 1, actorID = 6, screenName = "President Snow" });
            context.ScreenNames.AddOrUpdate(new ScreenName() { movieID = 4, actorID = 3, screenName = "President Lion" });
            context.ScreenNames.AddOrUpdate(new ScreenName() { movieID = 3, actorID = 1, screenName = "President Cat" });
        }
    }
}
