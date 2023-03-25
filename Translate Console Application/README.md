<h2> Translate Console Application </h2>

<strong> This console application is created using Azure Translator API.</strong>

<br>
<br>
After starting the program you are prompted to choose a language code to translate from, and the language code you want to translate the text to.
The program uses while loop, so the command will ask you for a text until you write "End" to close the program. You can see the supported languages, their codes 
and additional information from the table below.
<br>
<br>
<br>

<h2>Translation</h2>
<div>
<p>Language code <code>pt</code> will default to <code>pt-br</code>, Portuguese (Brazil).</p>
</div>

<br>

<h2> Supported languages and their codes: </h2>
<div class="has-inner-focus table-wrapper" tabindex="0" role="group" aria-label="Horizontally scrollable data">
<table aria-label="Supported Languages" class="table table-xxs">
<thead>
<tr>
<th style="text-align: left;">Language</th>
<th style="text-align: center;">Language code</th>
<th style="text-align: center;">Cloud – Text Translation and Document Translation</th>
<th style="text-align: center;">Containers – Text Translation</th>
<th style="text-align: center;">Custom Translator</th>
<th style="text-align: center;">Auto Language Detection</th>
<th style="text-align: center;">Dictionary</th>
</tr>
</thead>
<tbody>
<tr>
<td style="text-align: left;">Afrikaans</td>
<td style="text-align: center;"><code>af</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Albanian</td>
<td style="text-align: center;"><code>sq</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Amharic</td>
<td style="text-align: center;"><code>am</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Arabic</td>
<td style="text-align: center;"><code>ar</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Armenian</td>
<td style="text-align: center;"><code>hy</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr> 
<td style="text-align: left;">Assamese</td>
<td style="text-align: center;"><code>as</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Azerbaijani (Latin)</td>
<td style="text-align: center;"><code>az</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Bangla</td>
<td style="text-align: center;"><code>bn</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Bashkir</td>
<td style="text-align: center;"><code>ba</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Basque</td>
<td style="text-align: center;"><code>eu</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Bosnian (Latin)</td>
<td style="text-align: center;"><code>bs</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Bulgarian</td>
<td style="text-align: center;"><code>bg</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Cantonese (Traditional)</td>
<td style="text-align: center;"><code>yue</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Catalan</td>
<td style="text-align: center;"><code>ca</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Chinese (Literary)</td>
<td style="text-align: center;"><code>lzh</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Chinese Simplified</td>
<td style="text-align: center;"><code>zh-Hans</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Chinese Traditional</td>
<td style="text-align: center;"><code>zh-Hant</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Croatian</td>
<td style="text-align: center;"><code>hr</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Czech</td>
<td style="text-align: center;"><code>cs</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Danish</td>
<td style="text-align: center;"><code>da</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Dari</td>
<td style="text-align: center;"><code>prs</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Divehi</td>
<td style="text-align: center;"><code>dv</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Dutch</td>
<td style="text-align: center;"><code>nl</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">English</td>
<td style="text-align: center;"><code>en</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Estonian</td>
<td style="text-align: center;"><code>et</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Faroese</td>
<td style="text-align: center;"><code>fo</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Fijian</td>
<td style="text-align: center;"><code>fj</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Filipino</td>
<td style="text-align: center;"><code>fil</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Finnish</td>
<td style="text-align: center;"><code>fi</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">French</td>
<td style="text-align: center;"><code>fr</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">French (Canada)</td>
<td style="text-align: center;"><code>fr-ca</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Galician</td>
<td style="text-align: center;"><code>gl</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Georgian</td>
<td style="text-align: center;"><code>ka</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">German</td>
<td style="text-align: center;"><code>de</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Greek</td>
<td style="text-align: center;"><code>el</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Gujarati</td>
<td style="text-align: center;"><code>gu</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Haitian Creole</td>
<td style="text-align: center;"><code>ht</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Hebrew</td>
<td style="text-align: center;"><code>he</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Hindi</td>
<td style="text-align: center;"><code>hi</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Hmong Daw (Latin)</td>
<td style="text-align: center;"><code>mww</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Hungarian</td>
<td style="text-align: center;"><code>hu</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Icelandic</td>
<td style="text-align: center;"><code>is</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Indonesian</td>
<td style="text-align: center;"><code>id</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Inuinnaqtun</td>
<td style="text-align: center;"><code>ikt</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Inuktitut</td>
<td style="text-align: center;"><code>iu</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Inuktitut (Latin)</td>
<td style="text-align: center;"><code>iu-Latn</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Irish</td>
<td style="text-align: center;"><code>ga</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Italian</td>
<td style="text-align: center;"><code>it</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Japanese</td>
<td style="text-align: center;"><code>ja</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Kannada</td>
<td style="text-align: center;"><code>kn</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Kazakh</td>
<td style="text-align: center;"><code>kk</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Khmer</td>
<td style="text-align: center;"><code>km</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Klingon</td>
<td style="text-align: center;"><code>tlh-Latn</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Klingon (plqaD)</td>
<td style="text-align: center;"><code>tlh-Piqd</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Korean</td>
<td style="text-align: center;"><code>ko</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Kurdish (Central)</td>
<td style="text-align: center;"><code>ku</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Kurdish (Northern)</td>
<td style="text-align: center;"><code>kmr</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Kyrgyz (Cyrillic)</td>
<td style="text-align: center;"><code>ky</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Lao</td>
<td style="text-align: center;"><code>lo</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Latvian</td>
<td style="text-align: center;"><code>lv</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Lithuanian</td>
<td style="text-align: center;"><code>lt</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Macedonian</td>
<td style="text-align: center;"><code>mk</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Malagasy</td>
<td style="text-align: center;"><code>mg</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Malay (Latin)</td>
<td style="text-align: center;"><code>ms</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Malayalam</td>
<td style="text-align: center;"><code>ml</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Maltese</td>
<td style="text-align: center;"><code>mt</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Maori</td>
<td style="text-align: center;"><code>mi</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Marathi</td>
<td style="text-align: center;"><code>mr</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Mongolian (Cyrillic)</td>
<td style="text-align: center;"><code>mn-Cyrl</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Mongolian (Traditional)</td>
<td style="text-align: center;"><code>mn-Mong</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Myanmar</td>
<td style="text-align: center;"><code>my</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Nepali</td>
<td style="text-align: center;"><code>ne</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Norwegian</td>
<td style="text-align: center;"><code>nb</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Odia</td>
<td style="text-align: center;"><code>or</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Pashto</td>
<td style="text-align: center;"><code>ps</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Persian</td>
<td style="text-align: center;"><code>fa</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Polish</td>
<td style="text-align: center;"><code>pl</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Portuguese (Brazil)</td>
<td style="text-align: center;"><code>pt</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Portuguese (Portugal)</td>
<td style="text-align: center;"><code>pt-pt</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Punjabi</td>
<td style="text-align: center;"><code>pa</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Queretaro Otomi</td>
<td style="text-align: center;"><code>otq</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Romanian</td>
<td style="text-align: center;"><code>ro</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Russian</td>
<td style="text-align: center;"><code>ru</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Samoan (Latin)</td>
<td style="text-align: center;"><code>sm</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Serbian (Cyrillic)</td>
<td style="text-align: center;"><code>sr-Cyrl</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Serbian (Latin)</td>
<td style="text-align: center;"><code>sr-Latn</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Slovak</td>
<td style="text-align: center;"><code>sk</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Slovenian</td>
<td style="text-align: center;"><code>sl</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Somali (Arabic)</td>
<td style="text-align: center;"><code>so</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Spanish</td>
<td style="text-align: center;"><code>es</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Swahili (Latin)</td>
<td style="text-align: center;"><code>sw</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Swedish</td>
<td style="text-align: center;"><code>sv</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Tahitian</td>
<td style="text-align: center;"><code>ty</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Tamil</td>
<td style="text-align: center;"><code>ta</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Tatar (Latin)</td>
<td style="text-align: center;"><code>tt</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Telugu</td>
<td style="text-align: center;"><code>te</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Thai</td>
<td style="text-align: center;"><code>th</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Tibetan</td>
<td style="text-align: center;"><code>bo</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Tigrinya</td>
<td style="text-align: center;"><code>ti</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Tongan</td>
<td style="text-align: center;"><code>to</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Turkish</td>
<td style="text-align: center;"><code>tr</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Turkmen (Latin)</td>
<td style="text-align: center;"><code>tk</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Ukrainian</td>
<td style="text-align: center;"><code>uk</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Upper Sorbian</td>
<td style="text-align: center;"><code>hsb</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Urdu</td>
<td style="text-align: center;"><code>ur</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Uyghur (Arabic)</td>
<td style="text-align: center;"><code>ug</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Uzbek (Latin</td>
<td style="text-align: center;"><code>uz</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Vietnamese</td>
<td style="text-align: center;"><code>vi</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Welsh</td>
<td style="text-align: center;"><code>cy</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
</tr>
<tr>
<td style="text-align: left;">Yucatec Maya</td>
<td style="text-align: center;"><code>yua</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
<tr>
<td style="text-align: left;">Zulu</td>
<td style="text-align: center;"><code>zu</code></td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;">✔</td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
<td style="text-align: center;" aria-label="No value"></td>
</tr>
</tbody>
</table></div>
