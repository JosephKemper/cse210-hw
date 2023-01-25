using System;

public class JournalPrompt
{
    
    public int GenerateIndex()
    {
        Random randomIndex = new Random();
        int promptIndex = randomIndex.Next(0,245);
        return promptIndex;
    }

    public string GeneratePrompt(int promptIndex)
    {
    
// promptList source https://www.developgoodhabits.com/journal-prompts/
List<string> promptList = new List<string> {
"I'm grateful for...", 
"I remember when...",
"Once, when I was...",
"I've sometimes thought that...",
"It seems as if...",
"When I was a child...",
"One of my happiest memories is...",
"The thing I dread most is...",
"I remember when we...",
"My mother/father always...",
"I have never...",
"One day, I would like to go to...",
"If I had more time, I would like to learn to...",
"I recall a time when all I seemed to need was...",
"At the top of my bucket list is...",
"I wonder if...",
"I hope that...",
"One habit I would like to adopt is...",
"A habit I want to break is...",
"On rainy days...",
"In my neighborhood...",
"When my family gets together...",
"I wish I could find out...",
"During my downtime...",
"Looking at nature all around me, I think...",
"When I look out my window, I think...",
"When I'm doing nothing, my mind sometimes drifts to...",
"Looking at my face in the mirror...",
"Looking at my hands, I think about...",
"Watching people busily going by...",
"My favorite time of day is...",
"The coziest place for me is...",
"A warm sunny day inspires me to...",
"I'm unsure about...",
"I worry that...",
"I vividly remember...",
"The most extreme spectacle I've seen was...",
"Late at night, I sometimes...",
"The most nerve-racking thing for me is...",
"The people around me...",
"Someone I know...",
"I was astounded by...",
"It's confusing to think about...",
"It's overwhelming...",
"It's intriguing...",
"I dream of...",
"I'm fond of...",
"I'm always amused by...",
"It's satisfying when...",
"From my perspective, a life well lived means...",
"I feel disappointed about...",
"I'm deeply curious about...",
"I admire...",
"I'm ready to...",
"It makes sense to...",
"It doesn't make sense to...",
"I feel content when...",
"The unhappiest time for me was...",
"A period of uncertainty for me was during...",
"We were too busy to...",
"My parents taught me to...",
"One of the most profound experiences I remember was...",
"An event that helped shape my life...",
"I sometimes still feel bitterness about...",
"I'm trying to stop...",
"I've been considering...",
"I'm struck by...",
"It's so great to hear that...",
"I wish I could be more...",
"One thing I look forward to is...",
"I don't' want...",
"I can laugh about it now, but when...",
"There's nothing else like...",
"I need to stay away from...",
"I want to stop...",
"The most frightening...",
"One time, I...",
"My worst nightmare was about...",
"I knew I was taking a serious risk when I...",
"What concerns me right now is...",
"It's thrilling to think about...",
"I'm looking forward to...",
"The freest feeling in the world is when...",
"It's so refreshing to...",
"It's calming for me to...",
"It makes me feel cared for when...",
"I'm most at peace when...",
"I think it would be a bad idea to...",
"I don't talk about...",
"If I forgive...",
"I'm proud of...",
"I regret...",
"Even if...",
"As soon as possible, I plan to...",
"I'm not sure I have the courage to...",
"I don't know if I'm strong enough to...",
"I want to improve...",
"It's time for me to...",
"With practice, I believe I could...",
"I should strengthen...",
"Maybe it would be best to...",
"I don't think I spend enough time on...",
"I did not consider...",
"My priority needs to be...",
"I may be too sensitive about...",
"It was so funny when...",
"I'm not afraid to...",
"My plan for overcoming...",
"Within the next year or so...",
"Tomorrow, I will...",
"One relationship I want to nurture more is...",
"I think I was misunderstood when...",
"I'm not sure about...",
"I'm not interested in...",
"It makes me feel frustrated that...",
"I feel very angry that...",
"It was an awkward situation when...",
"It was embarrassing when...",
"It hurts to think about...",
"I prefer...",
"I feel very fortunate to have...",
"Too much pressure can cause me to...",
"I know it's time for a break when...",
"Reflecting on my relationships...",
"Looking back at my choices...",
"I'm inspired by...",
"It's annoying when...",
"One cliché that rings true is...",
"I've lost my...",
"I never want to let myself forget...",
"I can imagine that...",
"I will keep trying to...",
"Looking at my options for...",
"I feel stuck in the situation involving...",
"I've always wanted to try...",
"I see myself five years from now...",
"Examining my closest relationship(s), I think...",
"I'm probably not...",
"One area of my life that needs work is...",
"I need to speak up about...",
"A serious issue for me is...",
"I want to reach out to...",
"I'm going to have to face...",
"Maybe I can...",
"I should help...",
"I'm fed up with...",
"I'm thinking about changing my...",
"If I had three wishes, they would be...",
"I feel like I need more...",
"My favorite...",
"My deepest thinking is usually about...",
"If I could discover one hidden answer, it would be...",
"Analyzing myself, I've discovered...",
"Assessing the friendships I've built, I realize...",
"Recently, I heard someone say...",
"From my early years, I learned...",
"My own losses have taught me...",
"I learned I was stronger than I had thought I was when...",
"I want to do more to...",
"Even though I don't know what to say, I want to call...",
"I should just choke down my anxieties about it, and go...",
"One creative idea I have is...",
"I should just say what I really think about...",
"I want to know...",
"I don't know if I'll ever get over...",
"I have a feeling that...",
"It's not enough to...",
"It's more than enough to...",
"I could...",
"I just don't understand...",
"It feels like too much to expect...",
"I'm ready to raise my standards for...",
"I love my...",
"I don't like my...",
"Googling can help me find insights, but it can't...",
"It's true that...",
"I love the idea of...",
"There's nothing more...",
"I wonder why...",
"I will never again...",
"I've made up my mind that...",
"It's so intimidating to...",
"It's so exhilarating to...",
"My greatest thrill was...",
"It meant so much to me when...",
"I put all my energy into...",
"There's so much to figure out about...",
"I've finally learned my lesson about...",
"It's not easy to accept...",
"I could write a book about...",
"I'm holding a grudge about...",
"One of the most special moments of my life was...",
"I don't know how to feel about...",
"It's rough just thinking about...",
"I am confident that...",
"It's not easy for me to forget...",
"It warmed my heart to know that...",
"It makes me mad just thinking about...",
"I find myself thinking a lot lately about...",
"If I could turn back the clock...",
"It's reassuring to know that...",
"Of all the memories of my teen years...",
"The most painful time of my life was...",
"If I had gone down that road not taken...",
"I need to decide...",
"It's past time for me to just step up and say...",
"Looking to the future, I wonder...",
"I always assumed that by now I would...",
"It's best for me to be forgiving, because",
"I'm excited about the possibility of...",
"There's still time for me to...",
"My feelings were hurt when...",
"My best feature is...",
"I think my worst flaw is...",
"What am I going to do about...",
"It was a weird week, because of...",
"I believe...",
"I don't know why...",
"My biggest passion is for...",
"I trust that...",
"I've always found...",
"I most fear...",
"I was shocked when...",
"I wish I knew...",
"I've never talked to anyone about...",
"One of my biggest regrets is...",
"My biggest personal growth has been in the area of...",
"A great source of happiness for me has been...",
"What's most important to me is...",
"Reflecting on my life up to now, I see...",
"It feels too difficult for me to...",
"I find it easy to...",
"In the past, I never could have...",
"I feel humbled by...",
"I think people think that I am...",
"It's taken me a long time to...",
"I've never experienced...",
"I've always felt too afraid to...",
"One of my most precious memories is...",
"I've let my life be guided by...",
"I'd like to be remembered for...",
"I think that the meaning of life is...",
"The qualities I admire most in people are...",
"I don't let people see the side of me that is...",
"I want to help make the world a better place by...",
"Staring at the night sky, I think about...",
"I'm starting to understand..."
};
    return promptList[promptIndex];
}

}