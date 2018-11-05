<!DOCTYPE HTML>
<html>
<head>
    <meta charset="UTF-8">
    <title>Using RSS feeds</title>
</head>
<body>
    <?php
    $url = 'http://feeds.reuters.com/news/artsculture';
    $feed = simplexml_load_file($url, 'SimpleXMLIterator');
    echo "<h2>" . $feed->channel->description . "</h2><ol>";
    $filtered = new LimitIterator($feed->channel->item, 0,10);
    foreach($filtered as $item) { ?>
    <h4><li><a href = "<?= $item->link ; ?>" target="_blank"><?= $item->title; ?></a></li></h4>
    <?php
     date_default_timezone_set('America/New_York');
     $date = new DateTime($item->pubDate);
     $date->setTimezone(new DateTimeZone('America/New_York'));
     $offset = $date->getOffset();
     $timezone = ($offset == -14400) ? ' EDT' : ' EST' ;
     echo $date->format('M j, Y,g:ia') . $timezone;
    ?>
    <p><?php echo $item->description;?></p>
    <?php } ?>
    </ol>
</body>
</html>
