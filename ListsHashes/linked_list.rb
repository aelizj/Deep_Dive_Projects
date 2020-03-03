require_relative "LinkedListInterface"

class List < LinkedListInterface 
  def initialize
    @count = 0
    @is_empty =  true
    @item
    @first_value
    @last_value
    #@value
    #@next_value
  end

  def add_value(value)
    if @is_empty == true
      @item = ListItem.new(value)
      @count += 1 
      @is_empty = false  
      @first_value = @item.value      
      return
    else 
      @item.add_item(value)
      @count += 1 
      @last_value = value
      return
    end
  end

  def count   
    return @count
  end

  def first_value
    return @first_value
  end
  
  def last_value
    return @last_value
  end
  
  def get_value(index)
      if index > @count || index < 0 
        return "Index not found"
      end
      @item.get_item(index)
  end
  
  def remove_value(index)
    if index > @count || index < 0
      return "Index not found"
    end
    @item.remove_item(index)
  end
  
  def next_element
  end
end

#----------------------------------------------------

class ListItem
  attr_accessor :value
  
  def initialize(value = nil)
    @value = value
  end

  def add_item(value)  
    if @next_value == nil
      @next_value = ListItem.new(value)    
    else 
      @next_value.add_item(value) 
    end
  end  

  def get_item(index) 
    if index == 0      
      return @value
    else
      index -= 1
      @next_value.get_item(index)      
    end
  end

  def remove_item(index)
    if index == 0      
      return @value
    else
      index -= 1
      @next_value.get_item(index)      
    end
  end

  def next_item        
  end
end


#####################################################
b = List.new
 b.add_value("cat")
 b.add_value("dog")
 b.add_value("parrot")
 b.add_value("fish")
p b
p "COUNT = #{b.count}"
p b.get_value(0)
p b.get_value(1)
p b.get_value(2)
p b.get_value(3)
p b.get_value(-1)
p b.get_value(25)

b.first_value
b.last_value
 b.next_element

















# p a = List.new
# puts ""

# p "#-------- ADDING FIRST THING -----------#"
# a.add_value("thing 1")
# p a
# puts ""

# p "#--------- ADDING SECOND THING ----------#"
# a.add_value("thing 2")
# p a 
# puts ""

# p "#---------ADDING THIRD THING ----------#"
# a.add_value("thing 3")
# p a 
# puts ""

# p "#---------ADDING FOURTH THING ----------#"
# a.add_value("thing 4")
# p a 
# puts ""

# p "#---------ADDING FIFTH THING ----------#"
# a.add_value("thing 5")
# p a 
# puts ""

# p "#---------ADDING SIXTH THING ----------#"
# a.add_value("thing 6")
# p a 
# puts ""

# p a.first_value
# p a.last_value
# puts ""

# p a.get_value(0)
# p a.get_value(1)
# p a.get_value(2)
# p a.get_value(3)
# p a.get_value(4)
# p a.get_value(5)





 




















































#   def initialize(value = nil, next_value = nil)
#     @next_value = next_value
#     @value = value
#     @count = count = 0
#   end

#   def add_value(value)
#     p ">>> BEGINNING OF ADD_VALUE METHOD <<<"
#     if @next_value == nil
#       @next_value = List.new(value)
#       @count += 1
#       p "IF STATEMENT EXECUTED"
#     else 
#       @next_value.add_value(value)
#       @count += 1
#       p "ELSE STATEMENT EXECUTED"
#     end
#   end
  
#   def get_value(index)
#   end

#   def remove_value(index)
#   end

#   def next_element
#   end

#   def count
#   end

#   def first_value
#   end

#   def last_value
#   end
# end

# p a = List.new
# p a.add_value("thing") 
# p a
# p "First element added!\n"
# p a.add_value("stuff")
# p "Second element added!\n"
# p a









































##################################################################
# class List < LinkedListInterface
 
#     @value = value = nil
#     @next_element = nil
#     @count = 0
#     @first_value = nil
#     @last_value = nil
#     @is_empty = true
#     @index = index = 0

#   def add_value(value)
#     if @next_element == nil
#       @next_element = List.new
#       index = index += 1
#       @is_empty = false

#       p "Value = #{value}"
#       p "Next Element = #{@next_element}"
#       p "Counter = #{@counter}"
#       p "First Value = #{@first_value}"
#       p "Last Value = #{@last_value}"
#       p "Is Empty? = #{@is_empty}"
#       p "Index = #{index}"
#       puts ""
#       puts "IF STATEMENT EXECUTED"

#     else 
#       @next_element.add_value(value)
#       index += 1

#       p "Value = #{value}"
#       p "Next Element = #{@next_element}"
#       p "Counter = #{@counter}"
#       p "First Value = #{@first_value}"
#       p "Last Value = #{@last_value}"
#       p "Is Empty? = #{@is_empty}"
#       p "Index = #{index}"
#       puts ""
#       puts "ELSE STATEMENT EXECUTED"
#     end
#   end

#   def get_value(index)
#     return List.index
#   end

#   def remove_value(index)
#     List.index.remove
#   end

#   def next_element
#   end

#   def first_value   
#   end

#   def last_value
#   end

#   def counter
#     #@count = @count + 1    
#   end

# end

####################################################

