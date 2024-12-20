# Changelog

All notable changes to this package will be documented in this file.

The format is based on [Keep a Changelog](http://keepachangelog.com/en/1.0.0/)
and this project adheres to [Semantic Versioning](http://semver.org/spec/v2.0.0.html).

## [1.2.5] - 2024-08-20
* Added API to interact with Admin API
* Added API to interact with deployment capabilities
* Made upload more robust in some cases of partial success
* Fix issue where gsh deploy upload may fail in some cases
  * A partial upload would not be retried and a subsequent build version would fail to be created
* Fix with the upload command. It would not wait for sync if there was nothing to do. 

## [1.2.2] - 2024-04-30
* Updated content of apple privacy manifest

## [1.2.1] - 2024-04-30
* Added apple privacy manifest
* Updated com.unity.services.core to 1.12.5
* Updated com.unity.services.wire to 1.2.5

## [1.2.0] - 2024-04-05
* Disable authoring component if the Multiplayer SDK is present, to prefer that one over the one in this package
  * Multiplay will own the integration from [1-1.2)
  * Unified package will own it onwards

## [1.1.1] - 2023-11-08
* When creating a build, avoid switching target as this can cause a domain reload, instead emit a warning

## [1.1.0] - 2023-10-30
* Added support for editor authoring of Game Server Hosting files.

## [1.1.0] - 2023-10-27
* Added support for Deployment Window

## [1.0.5] - 2023-06-22
* Bugfix: Fixed an issue where editors above 2020.3 were having deserialization errors on ReadyServerForPlayersAsync calls.

## [1.0.4] - 2023-06-01
* Bugfix: Fixed an issue where deserializing a payload allocation was throwing an exception when used with Matchmaker.

## [1.0.3] - 2023-05-16
* Bugfix: Newtonsoft Json Default Settings no longer override SDK serialization behaviour.

## [1.0.0-pre.10] - 2023-04-28
* Additional stability improvements for Wire dependency.
* Updated Services Core dependency to 1.8.2.

## [1.0.0-pre.9] - 2023-04-13
* Added Server IpAddress property to ServerConfig class.

## [1.0.0-pre.8] - 2023-03-21

* Added support for renamed Game Server Hosting CLI module.
* Change the config file extension from .mps to .gsh.

## [1.0.0-pre.7] - 2023-01-04

* Fixed a bug when subscribing to server events that caused a race condition where events could be misse.

## [1.0.0-pre.6] - 2022-08-12

* Now supports Unity Editor Version 2020.3

## [1.0.0-pre.5] - 2022-08-03

* Updating supported unity editor version

## [1.0.0-pre.4] - 2022-08-02

* Fixed documentation and README
* Updated package dependencies

## [1.0.0-pre.3] - 2022-07-22

* Improved XML Docs for readiness
* Fixed an issue where, when deserializing a JSON response, a null reference exception could be thrown.
* Renamed IServerCheckManager to IServerQueryHandler
* Marked ServerConfig with Preserve attribute to protect it from code stripping
* Renamed AllocatedUuid to AllocationId

## [1.0.0-pre.2] - 2022-06-24

* Renamed some functions:
 * ServerReadyForPlayersAsync -> ReadyServerForPlayersAsync
 * ServerUnreadyAsync -> UnreadyServerAsync
 * ConnectToServerCheckAsync -> StartServerQueryHandlerAsync
* Fixed connection to payloadproxy
* Windows builds now uses HOMEPATH instead of HOME to read server.json

## [1.0.0-pre.1] - 2022-03-28

* Initial version of the Multiplay SDK package.
