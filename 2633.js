var jsonStringify = function(ob) {
    return  helper(ob)
}

const helper = function(idk){
    if(typeof idk == "number"){
        return `${idk}`
    }else  if (typeof idk == "undefined"){
        return "undefined"
    }else if (typeof idk == "boolean"){
        return idk.toString()
    } else if (typeof idk == "string"){
        return `"${idk}"`
    }
    else if(Array.isArray(idk)){
        var stt = "["
        idk.forEach(item => {
            stt += `${helper(item)},`
        })
        if(stt.length > 1){
            stt = stt.slice(0,-1)
        }
        stt+="]"
        return stt
    }
    else if (typeof idk ==  "object"){
        if(idk === null){
            return "null"
        }
        const kiez = Object.keys(idk)

        let retstr2 = "{"
        kiez.forEach(element => {
        retstr2  += `"${element}":${helper(idk[element])},` 
        });
        if(retstr2.length > 1){
           retstr2 = retstr2.slice(0,-1)
        }
        retstr2 += "}"
        return retstr2;
    }
}


const testobj = {
    test1: 55,
    test2:"hi",
    test3:[1,2,3],
    test4: ["a", "b"],
    test5:{
        bar:21,
        baz:{
            foo:"mac"
        }
    },
    test6: true,
    test7: undefined,
    test8: null
}
console.log(stringify(testobj))
//
//
//
console.log(typeof null)
console.log(typeof undefined)
console.log(typeof true)
