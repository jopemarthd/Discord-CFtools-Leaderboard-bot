# Discord Bot with CFtools integration for a leaderboard

![image](https://user-images.githubusercontent.com/32497643/111087377-2e284600-8519-11eb-95e8-0b82b281b24a.png)


### Instructions

- Edit the settings.json file in the bot folder
    ```
	{
		"token": "<Your Discord BOT Token>",
		"secret":"<Your Hashed CFTools APP Key>",
		"User-Agent":"<Your Application ID for your CFTools APP>",
		"Client-ID":"<Your Client ID for your CFTools APP",
		"Service-Token":"<Your service_token>",
		"title" : "<Title for the Leaderboard message>",
		"Logo" : "<Your image for the logo>",
		"url" : "<Url you want the Hyperlink on the message to send the user>"
	}
    ```
    - token is your discord bot token
    - secret is your Hashed app key (given when you create your CFTools APP)
    - User-Agent is your Application ID for your CFTools APP
    - Client-ID is your Client ID for your CFTools APP
    - Service-Token is your Token that you use to access the information for that specific server, **to get this token you can use the .exe file on this github repository, the source code for that application will be here will be on the Cftools-Discordbot-Helper folder.**
    - title will change the title of the message on the bot
    - Logo it will change the Source url to the logo on the message
    - Url changes the Hyperlink on the message to send the user


- Get and install [Node.js](https://nodejs.org/en/download/)
- run `npm i` to install node packages
- run `npm instal xmlhttprequest --save` to intall what you will need to connect to the API
- run `npm install -g nodemon`
- Start bot with `npm start`


## Discord Commands
`!leaderboard`: Displays the leaderboard
`!longestkill`: Displays the longest kill leaderboard

## Error reporting
Please post all error reports [here](https://github.com/jopemarthd/Discord-Leaderboard-CFToolsAPI/issues). Be sure to include error messages and any logs!
