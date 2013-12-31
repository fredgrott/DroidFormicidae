-----------------------------------------------------------------------
How To Build Public Source Distribution:
-----------------------------------------------------------------------

 1. [Optional] Download the latest project source distribution and
    any required third-party libraries (see below).

 2. [Optional] Rename ez-build.xml "build.xml". Otherwise use
    'ant -f' option with the ez-build.xml file.

 3. [Optional] Configure ez-build.properties as appropriate for your
    environment.

 4. Verify build classpath is appropriate (ez-build does *NOT*
    assume any class path information, it uses whatever the system
    classpath is defined to be).

 5. Run ant from local work area ('ant -file ez-build.xml' if 
    step 2 skipped). This produces a directory 'out' containing the
    generated antlib jar(s), javadocs, and a source jar file suitable
    for linking in an IDE or uploading to an artifact repository.


Required Third-party Libraries

 Any libraries, other than Ant, that the project requires can be  
 found in the "bin_withdeps" binary distribution. If no such distro
 exists then only Ant is required. You are free to try versions of
 the dependencies that are newer than the ones we ship. However, 
 if you do this, you should use the project's programmer test suites
 to verify that the newer libraries are completely compatible.

-----------------------------------------------------------------------
$Id: ez-build-README.txt 1390 2012-07-28 19:38:08Z ssmc $
