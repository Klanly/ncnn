function downloadString(text, fileType, fileName) {
  var blob = new Blob([text], { type: fileType });

  var a = document.createElement('a');
  a.download = fileName;
  a.href = URL.createObjectURL(blob);
  a.dataset.downloadurl = [fileType, a.download, a.href].join(':');
  a.style.display = "none";
  document.body.appendChild(a);
  a.click();
  document.body.removeChild(a);
  setTimeout(function() { URL.revokeObjectURL(a.href); }, 1500);
}

function fistr()
{

var alul=thumb.length;
for(var i=0;i<alul;i++) {thumb[i]+='\t'+vids[i]+'\t'+msgs[i];}
thumb[alul-1]+='\n';
downloadString(thumb.join('\n'),'text/csv','rlines.'+thiid);


thumb=null;
vids=null;
msgs=null;
}

fistr();