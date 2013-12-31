DroidFormicidae
---

DroidFormicidae is a set of ant build scripts for android development.


# Best Practices

The following best practices are followed and implemented in the build scripts:

* Version and release number of the android spupport library is kept tracked of
and detailed in javadocs.
* Because we use the Espresso to  test the UI we log our build script
output to a log file as the Google Espress Test Runner puts extra log information
in the logcat output each time a view is mtached via hamcrest matchers.
* We use Google's Android Ant Tasks to pull the two uses-sdk values to suppliment the
the information provided by the javadoc that is generated.
* We generate Checkstyle, Classycle, Jdepend, JavaNCSS, EMMA and Android Lint reports
for Code QA purposes.
* To black box test to find all the ANRs to fix we use MonkeyRunner in DroidAphidzMonkey
with a set of python Ant tasks to execute it.
* Testing workflow where we emphasize asethics is completed using
Sikuli in DroidAphidzSikuli using the alpha Sikuli Android plugin.

# Apache Ant Version

Uses Apache Ant 1.8.4 or higher

# License

Copyright 2013 Fred Grott GrottWorkShop

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.


# Android Development Resources

As always Google Engineers and OEM Engineers do not answer direct android
application development questions by emial and so these resources are
somewhat better to use for that purpose.

<a href="https://plus.google.com/u/0/communities/105153134372062985968">G+ Android Application Development Circle</a>
<a href="https://plus.google.com/u/0/communities/113499773637471211070">G+ Android Design Circle(private invite only</a>
<a href="http://stackoverflow.com/questions/tagged/android">Stackoverflow Android Area</a>






# About The Author

Fred Grott is an Android Application Engineer that develops android applications
for startups and firms in the Greater Chicago area. His encyclopedia of android
internals and android techniques combined with expert java and computer science
skills and knowledge make short work of tough and challenging development
problems for firms in the Greater Chicago area everything from mobile web applications
to hybrid mobile web and native applications and all the way to android native applications.

Being an Agile Rockstar Android Developer means Fred Grott uses expert java techniques to
choose what methods are effective to solve specific problems. For example, annotations
performance is not robust enough just yet to fully use dependency injection to separate
concerns so modifying MVC into Passive MVC is used to separate concerns such as business logic,
views, and model.

He can be followed on many of his Social Profiles:
<a href="http://about.me/fredgrott" rel="me">About.me</a>
<a href="https://angel.co/fred-grott" rel="me">AngelList</a>
<a href="http://www.behance.net/gwsfredgrott" rel="me">Behance</a>
<a href="<a href="http://grottworkshop.blogspot.com/" rel="me">Blogger</a>
<a href="https://bitbucket.org/fredgrott" rel="me">BitBucket</a>
<a href="http://www.builtinchicago.org/member/fredgrott" rel="me">BuiltInChicago</a>
<a href="http://chicagoandroid.com/profile/FredGrott" rel="me">ChicagoAndroid</a>
<a href="https://coderbits.com/FredGrott" rel="me">CoderBits</a>
<a href="https://coderwall.com/shareme" rel="me">CoderWall</a>
<a href="http://shareme.deviantart.com/" rel="me">DeviantArt</a>
<a href="http://dribbble.com/FredGrott" rel="me">Dribbble</a>
<a href="https://www.facebook.com/fred.grott" rel="me">Facebook</a>
<a href="http://forrst.com/people/fredgrott" rel="me">Forrst</a>
<a href="https://geekli.st/fredgrott" rel="me">GeekList</a>
<a href="https://github.com/shareme" rel="me">GitHub</a>
<a href="https://plus.google.com/u/0/114301140286672625486/about" rel="publisher" rel="me">G Plus</a>
<a href="https://news.ycombinator.com/user?id=fredgrott" rel="me">HackerNews</a>
<a href="http://html5-ninja.com/#/ninja/fredgrott" rel="me">Html5Ninja</a>
<a href="http://www.linkedin.com/in/shareme" rel="me">LinkedIN</a>
<a href="https://masterbranch.com/shareme" rel="me">MasterBranch</a>
<a href="http://www.reddit.com/user/fredgrott/" rel="me">Reddit</a>
<a href="https://www.quora.com/Fred-Grott" rel="me">Quora</a>
<a href="http://www.slideshare.net/shareme" rel="me">SlideShare</a>
<a href="https://speakerdeck.com/fredgrott" rel="me">SpeakerDeck</a>
<a href="http://stackoverflow.com/users/237740/fred-grott" rel="me">StackOverflow</a>
<a href="http://themeforest.net/user/fredgrott" rel="me">ThemeForrest</a>
<a href="http://androidhacker.tumblr.com/" rel="me">Tumblr</a>
<a href="https://twitter.com/fredgrott" rel="me">Twitter</a>
<a href="https://www.udemy.com/u/fredgrott/" rel="me">Udemy</a>
<a href="http://www.youtube.com/channel/UCRQadYlHQ8DKRQ_WwUrfZ_w" rel="me">YouTube</a>


His main websites are:


<a href="http://shareme.github.io" rel="me">GWS site at Github.io</a>

# Contacting Author

The author can be contacted by visiting these profiles and
using the contact links:
<a href"http://about.me/fredgrott" rel="me">About.me Profile<a>
<a href="https://plus.google.com/u/0/114301140286672625486/about" rel="me">Google Plus Profile</a>

# Endorse The Author

[![endorse](https://api.coderwall.com/shareme/endorsecount.png)](https://coderwall.com/shareme)