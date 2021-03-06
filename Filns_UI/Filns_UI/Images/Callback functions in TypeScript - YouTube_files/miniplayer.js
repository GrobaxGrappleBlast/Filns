(function(g){var window=this;'use strict';var B6=function(a){g.V.call(this,{G:"div",L:"ytp-miniplayer-ui"});this.re=!1;this.player=a;this.T(a,"minimized",this.zg);this.T(a,"onStateChange",this.vG)},C6=function(a){g.VM.call(this,a);
this.i=new B6(this.player);this.i.hide();g.IM(this.player,this.i.element,4);a.Me()&&(this.load(),g.N(a.getRootNode(),"ytp-player-minimized",!0))};
g.v(B6,g.V);g.k=B6.prototype;
g.k.rE=function(){this.tooltip=new g.vQ(this.player,this);g.I(this,this.tooltip);g.IM(this.player,this.tooltip.element,4);this.tooltip.scale=.6;this.uc=new g.ON(this.player);g.I(this,this.uc);this.Dg=new g.V({G:"div",L:"ytp-miniplayer-scrim"});g.I(this,this.Dg);this.Dg.Da(this.element);this.T(this.Dg.element,"click",this.iA);var a=new g.V({G:"button",Ga:["ytp-miniplayer-close-button","ytp-button"],W:{"aria-label":"Luk"},U:[g.PK()]});g.I(this,a);a.Da(this.Dg.element);this.T(a.element,"click",this.Ei);
a=new g.V1(this.player,this);g.I(this,a);a.Da(this.Dg.element);this.xp=new g.V({G:"div",L:"ytp-miniplayer-controls"});g.I(this,this.xp);this.xp.Da(this.Dg.element);this.T(this.xp.element,"click",this.iA);var b=new g.V({G:"div",L:"ytp-miniplayer-button-container"});g.I(this,b);b.Da(this.xp.element);a=new g.V({G:"div",L:"ytp-miniplayer-play-button-container"});g.I(this,a);a.Da(this.xp.element);var c=new g.V({G:"div",L:"ytp-miniplayer-button-container"});g.I(this,c);c.Da(this.xp.element);this.fN=new g.mP(this.player,
this,!1);g.I(this,this.fN);this.fN.Da(b.element);b=new g.kP(this.player,this);g.I(this,b);b.Da(a.element);this.nextButton=new g.mP(this.player,this,!0);g.I(this,this.nextButton);this.nextButton.Da(c.element);this.Gg=new g.gQ(this.player,this);g.I(this,this.Gg);this.Gg.Da(this.Dg.element);this.Fc=new g.tP(this.player,this);g.I(this,this.Fc);g.IM(this.player,this.Fc.element,4);this.Wz=new g.V({G:"div",L:"ytp-miniplayer-buttons"});g.I(this,this.Wz);g.IM(this.player,this.Wz.element,4);a=new g.V({G:"button",
Ga:["ytp-miniplayer-close-button","ytp-button"],W:{"aria-label":"Luk"},U:[g.PK()]});g.I(this,a);a.Da(this.Wz.element);this.T(a.element,"click",this.Ei);a=new g.V({G:"button",Ga:["ytp-miniplayer-replay-button","ytp-button"],W:{"aria-label":"Luk"},U:[g.UK()]});g.I(this,a);a.Da(this.Wz.element);this.T(a.element,"click",this.uV);this.T(this.player,"presentingplayerstatechange",this.Mc);this.T(this.player,"appresize",this.wb);this.T(this.player,"fullscreentoggled",this.wb);this.wb()};
g.k.show=function(){this.Kd=new g.Hq(this.lq,null,this);this.Kd.start();this.re||(this.rE(),this.re=!0);0!==this.player.getPlayerState()&&g.V.prototype.show.call(this);this.Fc.show();this.player.unloadModule("annotations_module")};
g.k.hide=function(){this.Kd&&(this.Kd.dispose(),this.Kd=void 0);g.V.prototype.hide.call(this);this.player.Me()||(this.re&&this.Fc.hide(),this.player.loadModule("annotations_module"))};
g.k.xa=function(){this.Kd&&(this.Kd.dispose(),this.Kd=void 0);g.V.prototype.xa.call(this)};
g.k.Ei=function(){this.player.stopVideo();this.player.Ma("onCloseMiniplayer")};
g.k.uV=function(){this.player.playVideo()};
g.k.iA=function(a){if(a.target===this.Dg.element||a.target===this.xp.element)this.player.V().N("kevlar_miniplayer_play_pause_on_scrim")?g.SJ(this.player.yb())?this.player.pauseVideo():this.player.playVideo():this.player.Ma("onExpandMiniplayer")};
g.k.zg=function(){g.N(this.player.getRootNode(),"ytp-player-minimized",this.player.Me())};
g.k.md=function(){this.Fc.Wb();this.Gg.Wb()};
g.k.lq=function(){this.md();this.Kd&&this.Kd.start()};
g.k.Mc=function(a){g.U(a.state,32)&&this.tooltip.hide()};
g.k.wb=function(){g.GP(this.Fc,0,this.player.bb().getPlayerSize().width,!1);g.uP(this.Fc)};
g.k.vG=function(a){this.player.Me()&&(0===a?this.hide():this.show())};
g.k.dc=function(){return this.tooltip};
g.k.Ue=function(){return!1};
g.k.uf=function(){return!1};
g.k.zi=function(){return!1};
g.k.VA=function(){};
g.k.cn=function(){};
g.k.Vr=function(){};
g.k.Cn=function(){return null};
g.k.lj=function(){return new g.Ol(0,0,0,0)};
g.k.handleGlobalKeyDown=function(){return!1};
g.k.handleGlobalKeyUp=function(){return!1};
g.k.uq=function(a,b,c,d,e){var f=0,h=d=0,l=g.fm(a);if(b){c=g.Sq(b,"ytp-prev-button")||g.Sq(b,"ytp-next-button");var m=g.Sq(b,"ytp-play-button"),n=g.Sq(b,"ytp-miniplayer-expand-watch-page-button");c?f=h=12:m?(b=g.dm(b,this.element),h=b.x,f=b.y-12):n&&(h=g.Sq(b,"ytp-miniplayer-button-top-left"),f=g.dm(b,this.element),b=g.fm(b),h?(h=8,f=f.y+40):(h=f.x-l.width+b.width,f=f.y-20))}else h=c-l.width/2,d=25+(e||0);b=this.player.bb().getPlayerSize().width;e=f+(e||0);l=g.eg(h,0,b-l.width);e?(a.style.top=e+"px",
a.style.bottom=""):(a.style.top="",a.style.bottom=d+"px");a.style.left=l+"px"};
g.k.showControls=function(){};
g.k.al=function(){};
g.k.Bk=function(){return!1};g.v(C6,g.VM);C6.prototype.create=function(){};
C6.prototype.Li=function(){return!1};
C6.prototype.load=function(){this.player.hideControls();this.i.show()};
C6.prototype.unload=function(){this.player.showControls();this.i.hide()};g.UM("miniplayer",C6);})(_yt_player);
