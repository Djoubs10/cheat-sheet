# Git commands

- `git status` 
: To check the current state of the repository.
- `git add <file>` 
: To stage the file's changes.
- `git commit -m <message>`  
: To take a screenshot of the current directory.
- `git log`
: To view the history of the project. Special command : `git log --pretty=fromat:'%h %ad | %s%d [%an]' --graph --date=short`
- `git checkout <tag or hash>` 
: To go back into a previous commit.
- `git tag <name>` 
: To tag a commit
- `git checkout <file>`
: To go back to the commited version.
- `git reset HEAD <file>`
: To go back to the commited version without modifiying current repository.
- `git revert HEAD` 
: To undo a commited change. It generates a commit that remove the changes.
- `git reset --hard <tag or hash>` 
: Delete a commit made after the given tag/hash.
- `git add <file> && git commit --amend -m <message>`
: To add a file into latest commit.
- `git mv <file> <dir>`
: To move a file.
- `git branch <branchname>`
: To create a new branch based on the current one.
- `git checkout <branchname>`
: To switch to the branch.
- `git merge <branchname>`
: To bring changed og a branch to the current one.
### !! You have to choose a version and to commit it to resolve merge conflicts
- `git fetch`bash
: To pull changes from the remote repository without applying them locally. Use : `git merge origin/<branch>` to apply changes.
- `git pull`
: To pull and merge remote changes.
- `git branch --track <branch> origin/<branch>`
: To create a local branch tracked to the remote one.
