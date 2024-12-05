is_playing = True
x_turn = True

def print_board():
    print (f" {positions['top left']} | {positions['top middle']} | {positions['top right']}\n"
           f"---+---+---\n"
           f" {positions['mid left']} | {positions['mid middle']} | {positions['mid right']}\n"
           f"---+---+---\n"
           f" {positions['bot left']} | {positions['bot middle']} | {positions['bot right']}")

def print_introduction():
    print("How to play:")
    print("There are 3 rows - 'top', 'mid', and 'bot'")
    print("There are 3 columns - 'left', 'middle', and 'right'")
    print("Navigate through the board's cells by writing the row and column.")
    print("Example: 'mid left' input will place your mark on the middle row on the left column.")
    print_board()

def check_winner():
    # checking rows for a winner
    if positions["top left"] == positions["top middle"] == positions["top right"] != " ":
        return True
    if positions["mid left"] == positions["mid middle"] == positions["mid right"] != " ":
        return True
    if positions["bot left"] == positions["bot middle"] == positions["bot right"] != " ":
        return True

    #checking columns for a winner
    if positions["top left"] == positions["mid left"] == positions["bot left"] != " ":
        return True
    if positions["top middle"] == positions["mid middle"] == positions["bot middle"] != " ":
        return True
    if positions["top right"] == positions["mid right"] == positions["bot right"] != " ":
        return True

    #checking diagonals for a winner
    if positions["top left"] == positions["mid middle"] == positions["bot right"] != " ":
        return True
    if positions["bot left"] == positions["mid middle"] == positions["top right"] != " ":
        return True

    return False

def check_draw():
    return all(position != " " for position in positions.values())

positions = {
    "top left": " ",
    "top middle": " ",
    "top right": " ",
    "mid left": " ",
    "mid middle": " ",
    "mid right": " ",
    "bot left": " ",
    "bot middle": " ",
    "bot right": " "
}

print_introduction()

while is_playing:
    turn = 'X' if x_turn else 'O'

    print(f"It's {turn}'s turn")
    place = input().lower()

    if place in positions:
        if positions[place] == " ":
            positions[place] = turn

            if check_winner():
                print_board()
                print(f"Game over! {turn} wins!")
                break

            if check_draw():
                print_board()
                print("Draw! No one wins!")
                break

            x_turn = not x_turn
        else:
            print("This spot is already taken, please try again with a different cell.")
    else:
        print("Invalid input! Please enter a valid cell! e.g. 'top left'")

    print_board()