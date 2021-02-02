# Lucas Costa's personal create_links script, to create symlinks for my .dotfiles stuff
# DON'T FORGET, I need to 'chmod 764 file_name.sh' in order to execute this

ln -sv ~/Desktop/LucasProjects/LucasCosta_portfolio/.dotfiles/bash_profile ~/.bash_profile
ln -sv ~/Desktop/LucasProjects/LucasCosta_portfolio/.dotfiles/vimrc ~/.vimrc
ln -sv ~/Desktop/LucasProjects/LucasCosta_portfolio/.dotfiles/zshrc ~/.zshrc
ln -shv ~/Desktop/LucasProjects/LucasCosta_portfolio/.dotfiles/oh-my-zsh ~/.oh-my-zsh
ln -sv ~/Desktop/LucasProjects/LucasCosta_portfolio/.dotfiles/vscode-settings.json ~/Library/Application\ Support/Code/User/settings.json
