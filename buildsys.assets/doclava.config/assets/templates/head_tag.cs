<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<?cs if:page.metaDescription ?>
<meta name="Description" content="<?cs var:page.metaDescription ?>">
<meta name="keywords" content="<?cs include:"metakeywords.cs" ?>">
<?cs /if ?>
<link rel="shortcut icon" type="image/x-icon" href="<?cs var:toroot ?>favicon.ico" />
<title><?cs 
  if:page.title ?><?cs 
    var:page.title ?> | <?cs
  /if ?><?cs
  var:project.name ?></title>

<!-- STYLESHEETS -->
<!-- rather than the webfont load we do a local font load-->
<style type="text/css">
@font-face {
    font-family: "Inconsolata-Bold";
    src: url("<?cs var:toroot ?>assets/fonts/Inconsolata-Bold") format("truetype");
}
@font-face {
    font-family: "Roboto-Black";
    src: url("<?cs var:toroot ?>assets/fonts/Roboto-Black") format("truetype");
}
@font-face {
   font-family: "Roboto-BlackItalic":
   src: url("<?cs var:toroot ?>assets/fonts/RobotoBlackItalic") format("truetype");
}
@font-face {
   font-family: "Roboto-Bold";
   src: url("<?cs var:toroot ?>assets/fonts/Roboto-Bold") format("truetype");
}
@font-face {
   font-family: "Roboto-BoldCondensed";
   src: url("<?cs var:toroot ?>assets/fonts/Roboto-BoldCondensed") format("truetype");
}
@font-face {
   font-family: "Roboto-BoldCondensedItalic";
   src: url("<?cs var:toroot ?>assets/fonts/Roboto-BoldCondensedItalic") format("truetype");
}
@font-face {
   font-family: "Roboto-BoldItalic";
   src: url("<?cs var:toroot ?>assets/fonts/Roboto-BoldItalic") format("truetype");
}
@font-face {
   font-family: "Roboto-Condensed";
   src: url("<?cs var:toroot ?>assets/fonts/Roboto-Condensed") format("truetype");
}
@font-face {
   font-family: "Roboto-CondensedItalic";
   src: url("<?cs var:toroot ?>assets/fonts/Roboto-CondensedItalic") format("truetype");
}
@font-face {
   font-family: "Roboto-Italic";
   src: url("<?cs var:toroot ?>assets/fonts/Roboto-Italic") format("truetype");
}
@font-face {
   font-family: "Roboto-Light";
   src: url("<?cs var:toroot ?>assets/fonts/Roboto-Light") format("truetype");
}
@font-face {
   font-family: "Roboto-Medium";
   src: url("</cs var:toroot ?>assets/fonts/Roboto-Medium") format("truetype");
}
@font-face {
   font-family: "Roboto-MediumItalic";
   src: url("<?cs var:toroot ?>assets/fonts/Roboto-MediumItalic") format("truetype");
}
@font-face {
   font-family: "Roboto-Regular";
   src: url("<?cs var:toroot ?>assets/fonts/Roboto-Regular") format("truetype");
}
@font-face {
   font-family: "Roboto-Thin";
   src: url("<?cs var:toroot ?>assets/fonts/Roboto-Thin") format("trutype");
}
@font-face {
   font-family: "Roboto-ThinItalic";
   src: url("<?cs var:toroot ?>assets/fonts/Roboto-ThinItalic") format("truetype");
}
</style>
<link href="<?cs var:toroot ?>assets/css/default.css" rel="stylesheet" type="text/css">

<?cs if:reference ?>
<!-- FULLSCREEN STYLESHEET -->
<link href="<?cs var:toroot ?>assets/css/fullscreen.css" rel="stylesheet" class="fullscreen"
type="text/css">
<?cs /if ?>

<!-- JAVASCRIPT -->

<script src="<?cs var:toroot ?>assets/js/global-libraries-combined.js" type="text/javascript"></script>
<script type="text/javascript">
  var toRoot = "<?cs var:toroot ?>";
</script>
<script src="<?cs var:toroot ?>assets/js/docs.js" type="text/javascript"></script>
<script src="<?cs var:toroot ?>navtree_data.js" type="text/javascript"></script>

</head>