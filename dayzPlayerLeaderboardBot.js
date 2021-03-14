// Discord includes
const Discord = require('discord.js')
const client = new Discord.Client()
const settings = require('./settings.json');

// API includes
const XMLHttpRequest = require('xmlhttprequest').XMLHttpRequest;

client.on('ready', () => {
  console.log("Connected as " + client.user.tag)
})

client.on('message', (receivedMessage) => {
  if (receivedMessage.author == client.user) { // Prevent bot from responding to its own messages
    return
  }

  if (receivedMessage.content.startsWith("!")) {
    processCommand(receivedMessage)
  }
})

function processCommand(receivedMessage) {
  let fullCommand = receivedMessage.content.substr(1) // Remove the leading exclamation mark
  let splitCommand = fullCommand.split(" ") // Split the message up in to pieces for each space
  let primaryCommand = splitCommand[0] // The first word directly after the exclamation is the command
  let arguments = splitCommand.slice(1) // All other words are arguments/parameters/options for the command

  console.log("Command received: " + primaryCommand)
  console.log("Arguments: " + arguments) // There may not be any arguments

  switch (primaryCommand.toLowerCase()) {
    case 'help':
      helpCommand(arguments, receivedMessage)
      break;
    case 'leaderboard':
      getLeaderboard(receivedMessage);
      break;
    case 'longestkill':
      getLeaderboard(receivedMessage);
      break;
    case 'test':
      generateLeaderboard(arguments, receivedMessage)
      break;
    default: receivedMessage.channel.send("I'm not sure what you need help with. Try `!help [topic]`")
  }
}



function helpCommand(arguments, receivedMessage) {
  if (arguments.length > 0) {
    switch (arguments[0].toLowerCase()) {
      case 'leaderboard':
        receivedMessage.channel.send("!leaderboard [sort Type]\n```\nValid Sort Types:\n\tdeaths\n\tplayer_kills\n\tlongest_shot\n\t\zedkills\n\tdistance_traveled\n\nExample Usage:\n\t!leaderboard player_kills```");
        break;
      default: receivedMessage.channel.send("I'm not sure what you need help with. Try `!help [topic]`")
    }
  }
  else {
    receivedMessage.channel.send("I'm not sure what you need help with. Try `!help [topic]`")
  }
}

//#region gets player kill Leaderboard top 8
function getLeaderboard(receivedMessage) {
  var params = {
    "secret": settings.secret,
  }
  var xhr = new XMLHttpRequest();
  xhr.responseType = "json"; // xhr.response will be parsed into a JSON object
  xhr.open('POST', "https://cfapi.de/auth/login", true);
  xhr.setRequestHeader("User-Agent",settings['User-Agent']);
  xhr.setRequestHeader("Client-ID",settings['Client-ID']);
  xhr.send(JSON.stringify(params));
  xhr.onreadystatechange = processRequestToken;
  function processRequestToken(e) {
    if (xhr.readyState == 4 && xhr.status == 200) {
        var t = JSON.parse(xhr.responseText);
        SendLeaderboard(t.access_token,receivedMessage);
    }
  }
}

function SendLeaderboard(Token,receivedMessage)
{
  var xhr = new XMLHttpRequest();
  xhr.responseType = "json"; // xhr.response will be parsed into a JSON object
  xhr.open('GET', "https://cfapi.de/v2/omega/"+settings['Service-Token']+"/leaderboard?order=descending&stat=kills&limit=8", true);
  xhr.setRequestHeader("User-Agent",settings['User-Agent']);
  xhr.setRequestHeader("Client-ID",settings['Client-ID']);
  xhr.setRequestHeader('Authorization', 'Bearer ' + Token);
  xhr.send();
  xhr.onreadystatechange = processRequest;
   
  function processRequest(e) {
      if (xhr.readyState == 4 && xhr.status == 200) {
          var data = JSON.parse(xhr.responseText);
          writeLeaderboard(data,receivedMessage);
      }
  }
}

function writeLeaderboard(playerData, receivedMessage) {
  const ServerLeaderBoad = {
    color: 0x0099ff,
    title: 'Here is the top 8 server Stats',
    url: settings.url,
    author: {
      name: settings.title,
    },
    thumbnail: {
      url: settings.Logo,
    },
    fields: [

    ],
    timestamp: new Date(),
    footer: {
      text: 'Leaderboard made by JopemartHD',
    },
  };
  for(var idx = 0;idx < 8; idx++)
  {
    var pName = {      name: (idx+1),      
    value: playerData.users[idx].latest_name,      
    inline: true,   
   }
   ServerLeaderBoad.fields.push(pName)
    var pKills = {      name: 'Kills:',      
    value: playerData.users[idx].kills,      
    inline: true,   
   }
   ServerLeaderBoad.fields.push(pKills)
   var pDeaths = {      name: 'Deaths:',      
    value: playerData.users[idx].deaths,      
    inline: true,   
   }
   ServerLeaderBoad.fields.push(pDeaths)
  
}
  
  receivedMessage.channel.send({ embed: ServerLeaderBoad });
}
//#endregion

// Get your bot's secret token from:
// https://discordapp.com/developers/applications/
// Click on your application -> Bot -> Token -> "Click to Reveal Token"
bot_secret_token = settings.token

client.login(bot_secret_token)
