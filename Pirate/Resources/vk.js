
/******************************************************/
/* These functions came from audioplayer.js on vk.com */
/******************************************************/

var a = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMN0PQRSTUVWXYZO123456789+/=";

function isObject(obj) { return Object.prototype.toString.call(obj) === '[object Object]'; }

/*	
function each(object, callback) {
	if (!isObject(object) && typeof object.length !== 'undefined') {
		for (var i = 0, length = object.length; i < length; i++) {
		  var value = object[i];
		  if (callback.call(value, i, value) === false) break;
		}
	} else {
		for (var name in object) {
		  if (!Object.prototype.hasOwnProperty.call(object, name)) continue;
		  if (callback.call(object[name], name, object[name]) === false)
			break;
		}
	}
	return object;
}*/

function each(e, t) {
        if (!e)
            return e;
        if (isObject(e) || "undefined" == typeof e.length) {
            for (var n in e)
                if (e.hasOwnProperty(n) && t.call(e[n], n, e[n]) === !1)
                    break
        } else
            for (var i = 0, a = e.length; a > i && t.call(e[i], i, e[i]) !== !1; i++)
                ;
     return e
}

function f(t, i) {
        var e = t.length
          , o = [];
        if (e) {
            var a = e;
            for (i = Math.abs(i); a--; )
                i = (e * (a + 1) ^ i + a) % e,
				o[a] = i
        }
        return o
    }
		 
var s = {
	v: function(t) {
		return t.split("").reverse().join("")
	},
	r: function(t, i) {
		t = t.split("");
		for (var e, o = a + a, s = t.length; s--; )
			e = o.indexOf(t[s]),
			~e && (t[s] = o.substr(e - i, 1));
		return t.join("")
	},
	s: function(t, i) {
            var e = t.length;
            if (e) {
                var o = f(t, i)
                  , a = 0;
                for (t = t.split(""); ++a < e; )
                    t[a] = t.splice(o[e - 1 - a], 1, t[a])[0];
                t = t.join("")
            }
            return t
    },
	i: function(e, t) {
	    return s.s(e, t ^ vkid)
    },
	x: function(t, i) {
		var e = [];
		return i = i.charCodeAt(0),
		each(t.split(""), function(t, o) {
			e.push(String.fromCharCode(o.charCodeAt(0) ^ i))
		}),
		e.join("")
	}
}

function e(t) {
	if (~t.indexOf("audio_api_unavailable")) {
		var i = t.split("?extra=")[1].split("#")
		  , e = "" === i[1] ? "" : o(i[1]);
		if (i = o(i[0]), 
		"string" != typeof e || !i)
			return t;
		e = e ? e.split(String.fromCharCode(9)) : [];
		for (var a, r, l = e.length; l--; ) {
			if (r = e[l].split(String.fromCharCode(11)),
                    a = r.splice(0, 1, i.toString() /*explicit conversion*/)[0],
                    !s[a])
                        return t;
			i = s[a].apply(null, r)
		}
		if (i && "http" === i.substr(0, 4))
			return i
	}
	return t
}

function o(t) {
	if (!t || t.length % 4 == 1)
		return !1;
	for (var i, e, o = 0, s = 0, r = ""; e = t.charAt(s++); )
		e = a.indexOf(e),
		~e && (i = o % 4 ? 64 * i + e : e,
		o++ % 4) && (r += String.fromCharCode(255 & i >> (-2 * o & 6)));
	return r
}