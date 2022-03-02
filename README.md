# interview-prep

## Big O Notation

### $O(n^2)$

Example:

```js
function square(n) {
    for(let i = 0; i < n; i++){
        for(let j = 0; j < n; i++){
            console.log(i, j);
        }
    }
}
```
