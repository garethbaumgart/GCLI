# GCommandLine
Command line tool to improve development productivity

## Usage
Both encrypt and decrypt commands will output there encrypted/ decrypted values, as well as copy them to your clipboard.
### Encrypt Text
``` zsh
gcmd encryt "plainText" --key "encryptionKey" --salt "salt"
```
### Decrypt Text
``` zsh
gcmd decryt "cypherText" --key "encryptionKey" --salt "salt"
```