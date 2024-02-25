Game: Cannoneer
Controls: 
- W,A,S,D rotate cannon barrel.
- Q and E to adjust power.
- F to fire.

This game was started from a fork of Solana 2048 which was started from the games template lumberjack: https://github.com/solana-developers/solana-game-starter-kits/tree/main/lumberjack

These are the Solana2048 Setup Docs (with which this repo shares all dependencies):

-----------------------------------------------------------------------------------
This game was started from the games template lumberjack: https://github.com/solana-developers/solana-game-starter-kits/tree/main/lumberjack

You can try out a deployed demo here: https://solplay.de/solana-2048/

And download an apk here: https://solplay.de/solana-2048/solana2048.apk

Notice that to play you will need to create an account and it will automatically fund a session wallet. The sol in there you will get back when the session expires. 

# Disclaimer
Neither gum session token nor the solana-2048 program are audited. Use at your own risk.
This is an example game and not a finished product. It is not optimized for security.

Todos: 
- Check if there will be conjestion on the highscore account since its part of every move. Could be moved to a submit highscore function, but would be less nice. 
- Track performance of processed socket commitment using whirligig and without
- Fix Unity SDK nft loading, which throws exceptions when json doesnt exist and has a huge memory footprint
- Handle waiting for session token properly as soon as its possible to figure out if a transaction was rejected in UnitySDK
- Decide if it would make sense to verify that the NFT used for the PDA is actually owned by the player.


How to build this example:

Anchor program
1. Install the [Anchor CLI](https://project-serum.github.io/anchor/getting-started/installation.html)
2. `cd solana-2048` `cd program` to end the program directory
3. Run `anchor build` to build the program
4. Run `anchor deploy` to deploy the program
5. Copy the program id into the lib.rs and anchor.toml file
6. Build and deploy again

Unity client
1. Install Unity (https://unity.com)
2. Run the Scene Solana-2048
3. While in editor press the login editor button on the bottom left
4. Please adjust your RPC node URL in the Solana2048 Screen monobehaviour in the Solana2048 scene. (Helius, quicknode, triton and others all work for this. The performance differences are not significant according to my tests it is way more dependant on the validators) 

To generate a new version of the c# client use:
generate c# client: 
https://solanacookbook.com/gaming/porting-anchor-to-unity.html#generating-the-client
dotnet tool install Solana.Unity.Anchor.Tool
dotnet anchorgen -i target/idl/solana_twentyfourtyeight.json -o target/idl/ProgramCode.cs

