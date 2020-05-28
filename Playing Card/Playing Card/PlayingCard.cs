using System;

namespace Playing_Card
{
    public class PlayingCard
    {
        string[] ranks = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
        string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
        Random rnd = new Random();
        int r;
        int s;

        public void ExtragereCarte()
        {
            r = rnd.Next(12);
            s = rnd.Next(3);
            Console.WriteLine($"{ranks[r]} of {suits[s]}");
        }

        public void Citire()
        {
            if (s == 0)
            { 
            if (r == 0) { Console.WriteLine("Represents a thirst for knowledge or a special talent that you have."); }
            if (r == 1) { Console.WriteLine("A reminder of the importance of communication to avoid confrontations and disappointment."); }
            if (r == 2) { Console.WriteLine("A representation of immense creativity, but can also reference the stress that is often associated with the creative process."); }
            if (r == 3) { Console.WriteLine("Represents mental stability that may lead you to go on a great adventure."); }
            if (r == 4) { Console.WriteLine("An indication that it’s time to make a change and learn something new, such as a new hobby or sport."); }
            if (r == 5) { Console.WriteLine("Means that your intuition is on point – you should trust it in order to receive great benefits."); }
            if (r == 6) { Console.WriteLine("Represents feeling confined or trapped, usually in regards to a romantic relationship."); }
            if (r == 7) { Console.WriteLine("Indicates a time of confusion that can lead to significant problems in your relationships if things are not resolved."); }
            if (r == 8) { Console.WriteLine("Represents the completion of a project or phase of your life."); }
            if (r == 9) { Console.WriteLine("Means that you will be traveling in the near future."); }
            if (r == 10) { Console.WriteLine("Represents an honest and trustworthy person who may be your friend."); }
            if (r == 11) { Console.WriteLine("Represents a charismatic woman who is in a position of power."); }
            if (r == 12) { Console.WriteLine("Represents a man of integrity who is a generous and loyal friend."); }
            }

            if (s == 1)
            {
                if (r == 0) { Console.WriteLine("Means that an important message is coming that will relate to your love or business."); }
                if (r == 1) { Console.WriteLine("Indicates that good news regarding your finances or investments will come soon."); }
                if (r == 2) { Console.WriteLine("Represents indecisiveness regarding money, which may lead to arguments and legal issues."); }
                if (r == 3) { Console.WriteLine("A reminder that financial responsibility is necessary in order to achieve stability and prosperity."); }
                if (r == 4) { Console.WriteLine("A financial change is coming – this may be a positive change (such as getting a new job) or a negative change (like an unexpected expense)."); }
                if (r == 5) { Console.WriteLine("Indicates a need to assume financial responsibility over your budget, investments, and/or debts."); }
                if (r == 6) { Console.WriteLine("A warning to be careful with your investments, as financial troubles are on the horizon."); }
                if (r == 7) { Console.WriteLine("Unexpected financial gains are coming your way – consider a budget and plan for savings."); }
                if (r == 8) { Console.WriteLine("Represents an upcoming expense, such as repairs, bills, or a large purchase."); }
                if (r == 9) { Console.WriteLine("This card is a great sign, as it represents a big financial success that is coming."); }
                if (r == 10) { Console.WriteLine("Represents someone who will be the bearer of bad news."); }
                if (r == 11) { Console.WriteLine("Represents a sophisticated woman who loves to party and gossip."); }
                if (r == 12) { Console.WriteLine("Represents a powerful and successful businessman."); }
            }

            if (s == 2)
            {
                if (r == 0) { Console.WriteLine("Represents a new beginning, such as a new relationship, marriage, or some good news for yourself or someone close."); }
                if (r == 1) { Console.WriteLine("This “union of hearts” means it’s time to spend some quality time with your loved ones."); }
                if (r == 2) { Console.WriteLine("Like a third wheel, this represents indecision or a lack of commitment in a relationship."); }
                if (r == 3) { Console.WriteLine("A representation of a stable, secure, and committed romantic relationship or marriage."); }
                if (r == 4) { Console.WriteLine("Major change is coming to your home or family, such as a divorce, a loved one moving away, or a new home."); }
                if (r == 5) { Console.WriteLine("Indicates a time of peace and harmony where you can work well with others to achieve your goals and overcome obstacles."); }
                if (r == 6) { Console.WriteLine("Represents a partner or friend who is undependable and will let you down."); }
                if (r == 7) { Console.WriteLine("An upcoming social event will provide you with important business or romantic connections with someone that you meet there."); }
                if (r == 8) { Console.WriteLine("Represents wishing for more in a relationship, such as having a baby or taking your relationship to the next level."); }
                if (r == 9) { Console.WriteLine("Means that good news is coming and there will be a large gathering of people at a wedding or party."); }
                if (r == 10) { Console.WriteLine("Represents your lover or best friend – can also signify a couple when it appears with the Queen of Hearts."); }
                if (r == 11) { Console.WriteLine("Represents a female lover or fantasy, which may be an indication of marriage – also may represent a mother or a pregnant woman."); }
                if (r == 12) { Console.WriteLine("Represents an influential man who is romantic and affectionate, but also emotional – could be a father."); }
            }

            if (s == 3)
            {
                if (r == 0) { Console.WriteLine("Represents a time of significant change – one thing will come to an end in order to make room for something new."); }
                if (r == 1) { Console.WriteLine("Represents a difficult situation or decision that may cause a division between you and a loved one or friend."); }
                if (r == 2) { Console.WriteLine("The three spades represent tears, which are a reaction to a stressful situation involving bad news, indecision, fear, or your job."); }
                if (r == 3) { Console.WriteLine("Indicates that stability will soon return to your workplace or health – the troubling times are almost over."); }
                if (r == 4) { Console.WriteLine("You will soon be moving on and leaving behind what you currently know, such as a new job, a relocation, or the end of your relationship."); }
                if (r == 5) { Console.WriteLine("A warning that fate will soon strike and impact you, your work, or your finances."); }
                if (r == 6) { Console.WriteLine("Represents the loss of a friend or another significant person in your life due to a disagreement or problem."); }
                if (r == 7) { Console.WriteLine("Indicates that obstacles at work may soon put you at a crossroads where you will need to make an important decision."); }
                if (r == 8) { Console.WriteLine("A sign that there will soon be a loss or ending in your life, possibly the death of someone close to you."); }
                if (r == 9) { Console.WriteLine("Represents worry and grief that may be the result of health problems, fear, or bad news."); }
                if (r == 10) { Console.WriteLine("Represents a negative person in your life who may betray you or hold you back."); }
                if (r == 11) { Console.WriteLine("Represents a cruel woman who is extremely manipulative and malicious."); }
                if (r == 12) { Console.WriteLine("Represents an authoritative man who may create trouble in a relationship."); }
            }
        }
        
    }
}