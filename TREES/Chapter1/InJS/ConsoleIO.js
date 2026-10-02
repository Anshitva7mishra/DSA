const readline = require('readline');

class ConsoleIO
{
    constructor()
    {
        this.rl = readline.createInterface({
            input: process.stdin,
            output: process.stdout
        });
    }

    async getIntInput(promptText)
    {
        return new Promise((resolve) => {
            const ask = () => {
                this.rl.question(promptText, (input) => {
                    const parsed = parseInt(input.trim(), 10);
                    if(isNaN(parsed))
                    {
                        console.log("Invalid input. Please enter an integer.");
                    }
                    else
                    {
                        resolve(parsed);
                    }
                });
            };
            ask();
        });
    }

    close()
    {
        this.rl.close();
    }
}

module.exports = ConsoleIO;