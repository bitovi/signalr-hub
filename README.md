# Can Connect SignalR Test App Hub

`can-connect-signalr-test-app-hub` is a SignalR Hub that demonstrates how to implement the interfaces required for a
`can-connect-signalr` application.

### Setup Environment

Make sure you have installed:

- [VisualStudio 2015](https://www.visualstudio.com/downloads/) - or later (VS 2017)


### Download Source

Clone this repo using git:

```
git clone https://github.com/bitovi/signalr-hub.git
```

### Start the Server

Once you've downloaded the source files from the repo, you can run `can-connect-signalr-test-app-hub` locally in debug mode. 
Simply open it in VisualStudio, and either press `F5`, or click `Debug -> Start Debugging`.

The application will open in a browser window. If you get a message saying `HTTP Error 403.14 - Forbidden`, this is normal. You will still be able to connect to the Hub. Copy the URL from the browser's location bar, and use that as the URL property for the `SignalR` connection in your `can-connect-signalr` test application.

![SignalR Local Instance](https://raw.githubusercontent.com/bitovi/signalr-hub/master/debug_run.png)

```js
   signalR: {
        url: 'http://localhost:53246/', // The URL of the local SignalR Hub Instance
        name: "MessageHub"
    }
```

### Enjoy

:)
