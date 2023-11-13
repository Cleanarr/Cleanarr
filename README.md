# Cleanarr
## Automatic cleaner tool for Plex (and others soon...).

## Project will remain inactive for longer, maybe indefinitely...

## Please have a look at: https://github.com/jorenn92/Maintainerr

### _Project is in development!_
<br/>

**Cleanarr** will automatically delete movies and series-episodes from your Media Server.

It allows a user to set conditions that must be met in order 
for a movie or series-episode to get deleted.

The software will consist of 3 components.

-  Media Provider
-  History Provider
-  Request Provider


Cleanarr uses the providers to determine whether a movie or series-episode can be deleted.
You will have extended possibilities to create variations of conditions to have different circumstances for media te get deleted.

An example setup of conditions can be:

Watch conditions | Time-Out conditions | Mail condition
------------ | ------------- | -------------
The main user must have seen it | No Time-Out | No Mail
Everybody who have requested it must have seen it | 90 days Time-Out | Send Mail, send reminder mail 3 times
Everybody who started watching a show (1+ episode) / movie (10 min+) must have seen it | 90 days Time-Out | Send Mail, send reminder mail 2 times 
A particular user have seen it | 20 days Time-Out | Send Mail, no reminder mail

In this example Cleanarr will not delete the media as long as the main user hasn't watched it.
when the main user has watched it Cleanarr will accumulate all movies / series with the time-out reached in one e-mail to the particular user, 
and to everyone who has started watching- / requested the movie/series, but jet have seen it.
In the e-mail they will have the option to postpone the removal and reset the time-out period.
If they don't respond you can setup a reminder mail with a repeat limit or you can setup that without a respond the media will be deleted.
In the mail they can choose if they still intent to watch the movie/series or if it can be removed.

---

### Plugins

A plugin system is used to add compatibility for all three components.
The software will be shipped with pre-made plugins for: 

- Plex (Media Provider)
- Tautulli (History Provider)
- Ombi (Request Provider)

A Plugin API will be available to give other developers the opportunity to extend the compatibility of Cleanarr
to have support for other providers.
