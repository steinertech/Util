# GitHub
Clone
```
git clone git@github.com:steinertech/Util.git
cd Util
git config user.name # Show global 
git config user.name "SteinerTech" # Config for tihs repo
git config user.email # Show global
git config user.email "205841367+steinertech@users.noreply.github.com" # Config for this repo
ssh-keygen -t ed25519 -C "205841367+steinertech@users.noreply.github.com" # C:\Users\My/.ssh/SteinerTech
# Copy key from C:\Users\Admin\.ssh\SteinerTech.pub to https://github.com/settings/keys (SSH and GPG keys) # Gives access to all repos
```

# Git Command
Advanced git commands

# Commit Hash
```
git rev-parse --short HEAD # Show current commit
```

# Email
```
git config --global user.email # Show global email
git config user.email # Show email of repo
git show e1d6043 # Show email of commit
```

## Git Diff
Open git bash
```
cd /c/Temp/Git/My/
git add .
git diff main > my.diff # Creates diff of all staged files
git apply my.diff
```

## Git Rebase
```
git rebase --onto main
git push --force
```

## Git Undo
Undo commited changes (rewrites history!)
```
git push --force origin 9944d62:mybranch # Set branch mybranch back to commit 9944d62
```
