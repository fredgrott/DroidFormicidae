<?cs def:custom_masthead() ?>
    <!-- Header -->
    <div id="header">
        <div class="wrap" id="header-wrap">
          <div class="col-3 logo">
          <a href="<?cs var:toroot ?>index.html">
            <img src="<?cs var:toroot ?>assets/images/project_logo.png" width="25" height="25" alt="GWSDroidLava"/>
          </a>
          <div class="btn-quicknav" id="btn-quicknav">
                <a href="#" class="arrow-inactive">Quicknav</a>
                        <a href="#" class="arrow-active">Quicknav</a>
          </div>
          </div>
            <ul class="nav-x col-9">
                <li class="usage"><a href="<?cs var:toroot ?>usage/index.html" <?cs
                  if:design ?>class="selected"<?cs /if ?> >Usage</a></li>
                <li class="develop"><a href="<?cs var:toroot ?>develop/index.html" <?cs
                  if:codeqa || devguide || reference || devtools  ?>class="selected"<?cs /if ?> >Develop</a></li>
                <li class="getit last"><a href="<?cs var:toroot ?>getit/index.html" <?cs
                  if:getit ?>class="selected"<?cs /if ?> >GetIt</a></li>
            </ul>
            
            <!-- New Search -->
            <div class="menu-container">
            <div class="moremenu">
    <div id="more-btn"></div>
  </div>
  <div class="morehover" id="moremenu">
    <div class="top"></div>
    <div class="mid">
      <div class="header">Links</div>
      <ul>
        <li><a href="http://fredgrott.bitbucket.org">Fred Grott(GrottWorkShoop)</a></li>
        <li><a href="http://grottworkshop.blogspot.com/">Fred Grott(GWS) Blog</a></li>
      </ul>
      <div class="header">Android Sites</div>
      <ul>
        <li><a href="http://www.android.com">Android.com</a></li>
        <li class="active"><a>Android Developers</a></li>
        <li><a href="http://source.android.com">Android Open Source Project</a></li>
      </ul>
      
      <div class="header">Languages</div>
        <div id="language" class="locales">
          <select name="language" onChange="changeLangPref(this.value, true)">
              <option value="en">English</option>
              <option value="es">Español</option>
              <option value="ja">日本語</option>
              <option value="ko">한국어</option>
              <option value="ru">Русский</option>
              <option value="zh-CN">中文 (中国)
      </option>
          </select>     
        </div>
      <script type="text/javascript">
        <!--  
        loadLangPref();  
          //-->
      </script>
      <br class="clearfix" />
    </div>
    <div class="bottom"></div>
  </div>
  <div class="search" id="search-container">
    <div class="search-inner">
      <div id="search-btn"></div>
      <div class="left"></div>
      <form onsubmit="return submit_search()">
        <input id="search_autocomplete" type="text" value="" autocomplete="off" name="q"
onfocus="search_focus_changed(this, true)" onblur="search_focus_changed(this, false)"
onkeydown="return search_changed(event, true, '<?cs var:toroot ?>')" 
onkeyup="return search_changed(event, false, '<?cs var:toroot ?>')" />
      </form>
      <div class="right"></div>
        <a class="close hide">close</a>
        <div class="left"></div>
        <div class="right"></div>
    </div>
  </div>
  <div id="search_filtered_wrapper">
    <div id="search_filtered_div" class="no-display">
        <ul id="search_filtered">
        </ul>
    </div>
  </div>
  
  </div>
  <!-- /New Search>
          
          
          <!-- Expanded quicknav -->
           <div id="quicknav" class="col-9">
                <ul>
                    <li class="usage">
                      <ul>
                        <li><a href="<?cs var:toroot ?>usage/starting.html">Getting Started</a></li>
                        <li><a href="<?cs var:toroot ?>usage/advanced.html">Advanced</a></li>
                        
                      </ul>
                    </li>
                    <li class="develop">
                      <ul>
                        <li><a href="<?cs var:toroot ?>codeqa/index.html">Project CodeQA</a></li>
                        <li><a href="<?cs var:toroot ?>devguide/components/index.html">Dev Guides</a></li>
                        <li><a href="<?cs var:toroot ?>reference/packages.html">Reference</a></li>
                        <li><a href="<?cs var:toroot ?>devtools/index.html">DevTools</a></li>
                      </ul>
                    </li>
                    <li class="getit last">
                      <ul>
                        <li><a href="<?cs var:toroot ?>getit/projectlibrary.html">Jar</a></li>
                        <li><a href="<?cs var:toroot ?>getit/source.html">Publishing</a></li>
                        </ul>
                    </li>
                </ul>
          </div>
          <!-- /Expanded quicknav -->
        </div>
    </div>
    <!-- /Header -->
    
    
  <div id="searchResults" class="wrap" style="display:none;">
          <h2 id="searchTitle">Results</h2>
          <div id="leftSearchControl" class="search-control">Loading...</div>
  </div>
    
    
    
<?cs if:codeqa || devguide || reference || devtools || develop ?>
    <!-- Secondary x-nav -->
    <div id="nav-x">
        <div class="wrap">
            <ul class="nav-x col-9 develop" style="width:75%">
                <li><a href="<?cs var:toroot ?>codeqa/index.html" <?cs
                  if:codeqa ?>class="selected"<?cs /if ?> >Project CodeQA</a></li>
                  <li><a href="<?cs var:toroot ?>devguide/index.html" <?cs
                  if:devguide ?>class="selected"<?cs /if ?> >Dev Guides</a></li>
                <li><a href="<?cs var:toroot ?>reference/packages.html" <?cs
                  if:reference ?>class="selected"<?cs /if ?> >Reference</a></li>
                <li><a href="<?cs var:toroot ?>devtools/index.html" <?cs
                  if:devtools ?>class="selected"<?cs /if ?> >Dev Tools</a></li>
            </ul>
          
        </div>
        
    </div>
    <!-- /Sendondary x-nav -->
<?cs /if ?>
  <?cs 
/def ?>