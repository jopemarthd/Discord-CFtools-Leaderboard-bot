# DayZ Player Leaderboard Bot with CFtools integration

![image](https://user-images.githubusercontent.com/32497643/111087377-2e284600-8519-11eb-95e8-0b82b281b24a.png)


### Instructions

- Create settings.json file with the following format
    ```
	{
		"token": "<Your Discord BOT Token>",
		"secret":"<Your Hashed CFTools APP Key>",
		"User-Agent":"<Your Application ID for your CFTools APP>",
		"Client-ID":"<Your Client ID for your CFTools APP",
		"Service-Token":"<Your service_token>",
		"Logo" : "<Your image for the logo>"
	}
    ```
    - token is your discord bot token
    - secret is your Hashed app key (given when you create your CFTools APP)
    - User-Agent is your Application ID for your CFTools APP
    - Client-ID is your Client ID for your CFTools APP
    - Service-Token is your Token that you use to access the information for that specific server, to get this token you have to send a request to                                     https://cfapi.de/v1/servicetokens to get it (it never changes so you only need to do it once).


- Get and install [Node.js](https://nodejs.org/en/download/)
- run `npm i` to install node packages
- run `npm instal xmlhttprequest --save` to intall what you will need to connect to the API
- Start bot with `npm start`


## Discord Commands
`!leaderboard`: Displays the leaderboard

## Error reporting
Please post all error reports [here](https://github.com/jopemarthd/Discord-Leaderboard-CFToolsAPI/issues). Be sure to include error messages and any logs!
