import pygame,sys
pygame.init()
pygame.display.set_caption('Flappy Bird Remake by Long')
Icon = pygame.image.load('Filegame/assets/yellowbird-midflap.png')
pygame.display.set_icon(Icon)
screen = pygame.display.set_mode((432,768))
clock = pygame.time.Clock()
bird_movement = 0
gravity = 0.25

#chèn bg
bg = pygame.image.load('Filegame/assets/background-night.png').convert()
bg = pygame.transform.scale2x(bg)

#chèn sàn
floor = pygame.image.load('Filegame/assets/floor.png').convert()
floor = pygame.transform.scale2x(floor)
floor_x_pos = 0

#tạo chim
bird = pygame.image.load('Filegame/assets/yellowbird-midflap.png').convert()
bird = pygame.transform.scale2x(bird)
bird_rect = bird.get_rect(center = (100,384))


def draw_floor():
    screen.blit(floor,(floor_x_pos,600))
    screen.blit(floor,(floor_x_pos + 432,600))

while True:
    for event in pygame.event.get():
        if  event.type == pygame.QUIT:
            pygame.quit()
            sys.exit()

        if event.type == pygame.KEYDOWN:
            if event.key == pygame.K_SPACE:
                bird_movement = -7
                        
    screen.blit(bg,(0,0))
    bird_movement += gravity
    bird_rect.centery += bird_movement
    screen.blit(bird,bird_rect)
    floor_x_pos -= 1
    draw_floor()
    if floor_x_pos == -432:
        floor_x_pos = 0
    pygame.display.update()
    clock.tick(120)
    