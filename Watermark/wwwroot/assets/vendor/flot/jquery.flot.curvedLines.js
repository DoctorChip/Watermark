!function(r){function n(r){function n(r,n){n.series.curvedLines.active&&r.hooks.processDatapoints.unshift(e)}function e(r,n,e){var t=e.points.length/e.pointsize;if(!u(n.curvedLines)&&1==n.curvedLines.apply&&void 0===n.originSeries&&t>1.005)if(n.lines.fill){var o=i(e,n.curvedLines,1),s=i(e,n.curvedLines,2);e.pointsize=3,e.points=[];for(var v=0,a=0,p=0;p<o.length||v<s.length;)o[p]==s[v]?(e.points[a]=o[p],e.points[a+1]=o[p+1],e.points[a+2]=s[v+1],v+=2,p+=2):o[p]<s[v]?(e.points[a]=o[p],e.points[a+1]=o[p+1],e.points[a+2]=a>0?e.points[a-1]:null,p+=2):(e.points[a]=s[v],e.points[a+1]=a>1?e.points[a-2]:null,e.points[a+2]=s[v+1],v+=2),a+=3}else n.lines.lineWidth>0&&(e.points=i(e,n.curvedLines,1),e.pointsize=2)}function i(r,n,e){if(void 0!==n.legacyOverride&&0!=n.legacyOverride){var i={fit:!1,curvePointFactor:20,fitPointDist:void 0};return s(r,jQuery.extend(i,n.legacyOverride),e)}return t(r,n,e)}function t(r,n,e){for(var i=r.points,t=r.pointsize,s=o(r,n,e),u=[],v=0,a=0;a<i.length-t;a+=t){var p=a,h=a+e,f=i[p],l=i[p+t],c=(l-f)/Number(n.nrSplinePoints);u.push(i[p]),u.push(i[h]);for(var d=f+=c;d<l;d+=c)u.push(d),u.push(s[v](d));v++}return u.push(i[i.length-t]),u.push(i[i.length-t+e]),u}function o(r,n,e){for(var i=r.points,t=r.pointsize,o=[],s=[],u=0;u<i.length-t;u+=t){var v=u,a=u+e,p=i[v+t]-i[v],h=i[a+t]-i[a];o.push(p),s.push(h/p)}var f=[s[0]];if(n.monotonicFit)for(var u=1;u<o.length;u++){var l=s[u],c=s[u-1];if(l*c<=0)f.push(0);else{var d=o[u],g=o[u-1],y=d+g;f.push(3*y/((y+d)/c+(y+g)/l))}}else for(var u=t;u<i.length-t;u+=t){var v=u,a=u+e;f.push(Number(n.tension)*(i[a+t]-i[a-t])/(i[v+t]-i[v-t]))}f.push(s[s.length-1]);var w=[],L=[];for(u=0;u<o.length;u++){var P=f[u],m=f[u+1],l=s[u],A=1/o[u],y=P+m-l-l;w.push(y*A*A),L.push((l-y-P)*A)}for(var z=[],u=0;u<o.length;u++){z.push(function(r,n,e,i,t){return function(o){var s=o-r,u=s*s;return n*s*u+e*u+i*s+t}}(i[u*t],w[u],L[u],f[u],i[u*t+e]))}return z}function s(r,n,e){var i=r.points,t=r.pointsize,o=Number(n.curvePointFactor)*(i.length/t),s=new Array,u=new Array,v=-1,a=-1,p=0;if(n.fit){var h;if(void 0===n.fitPointDist){var f=i[0];h=(i[i.length-t]-f)/5e4}else h=Number(n.fitPointDist);for(var l=0;l<i.length;l+=t){var c,d;v=l,a=l+e,c=i[v]-h,d=i[v]+h;for(var g=2;c==i[v]||d==i[v];)c=i[v]-h*g,d=i[v]+h*g,g++;s[p]=c,u[p]=i[a],p++,s[p]=i[v],u[p]=i[a],p++,s[p]=d,u[p]=i[a],p++}}else for(var l=0;l<i.length;l+=t)v=l,a=l+e,s[p]=i[v],u[p]=i[a],p++;var y=s.length,w=new Array,L=new Array;w[0]=0,w[y-1]=0,L[0]=0;for(var l=1;l<y-1;++l){var P=s[l+1]-s[l-1];if(0==P)return[];var m=(s[l]-s[l-1])/P,A=m*w[l-1]+2;w[l]=(m-1)/A,L[l]=(u[l+1]-u[l])/(s[l+1]-s[l])-(u[l]-u[l-1])/(s[l]-s[l-1]),L[l]=(6*L[l]/(s[l+1]-s[l-1])-m*L[l-1])/A}for(var p=y-2;p>=0;--p)w[p]=w[p]*w[p+1]+L[p];var z=(s[y-1]-s[0])/(o-1),b=new Array,D=new Array,F=new Array;for(b[0]=s[0],D[0]=u[0],F.push(b[0]),F.push(D[0]),p=1;p<o;++p){b[p]=b[0]+p*z;for(var O=y-1,N=0;O-N>1;){var j=Math.round((O+N)/2);s[j]>b[p]?O=j:N=j}var k=s[O]-s[N];if(0==k)return[];var S=(s[O]-b[p])/k,C=(b[p]-s[N])/k;D[p]=S*u[N]+C*u[O]+((S*S*S-S)*w[N]+(C*C*C-C)*w[O])*(k*k)/6,F.push(b[p]),F.push(D[p])}return F}function u(r){if(void 0!==r.fit||void 0!==r.curvePointFactor||void 0!==r.fitPointDist)throw new Error("CurvedLines detected illegal parameters. The CurvedLines API changed with version 1.0.0 please check the options object.");return!1}r.hooks.processOptions.push(n)}var e={series:{curvedLines:{active:!1,apply:!1,monotonicFit:!1,tension:.5,nrSplinePoints:20,legacyOverride:void 0}}};r.plot.plugins.push({init:n,options:e,name:"curvedLines",version:"1.1.1"})}(jQuery);